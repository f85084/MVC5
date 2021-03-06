﻿using Forum.Models;
using Forum.Services;
using Forum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        ArticleService articleService = new ArticleService();

        #region 開始頁面
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region 文章列表
        //將Page(頁數)預設為1
        public ActionResult List(string Search, int Page = 1)
        {
            //宣告一個新頁面模型
            ArticleView Data = new ArticleView();
            //將傳入值Search(搜尋)放入頁面模型中
            Data.Search = Search;
            //新增頁面模型中的分頁
            Data.Paging = new ForPaging(Page);
            //從Service中取得頁面所需陣列資料
            Data.DataList = articleService.GetDataList(Data.Paging, Data.Search);
            return PartialView(Data); //將頁面資料傳入View中
        }
        #endregion

        #region 文章頁面
        //文章頁面要根據傳入編號來決定要顯示的資料
        public ActionResult Article(int Id)
        {
            //取得頁面所需資料，藉由Service取得
            Article Data = articleService.GetDataById(Id);
            articleService.Watch(Id); //將資料庫內資料加一觀看人數
            return View(Data); //將資料傳入View中
        }
        #endregion

        #region 新增文章
        //新增文章一開始載入頁面
        [Authorize] //設定此Action須登入
        public ActionResult Create()
        {
            return PartialView();
        }

        //新增文章傳入資料時的Action
        [Authorize] //設定此Action須登入
        [HttpPost] //設定此Action只接受頁面POST資料傳入
        //使用Bind的Inculde來定義只接受的欄位，用來避免傳入其他不相干值
        public ActionResult Add([Bind(Include = "Title,Content")]Article Data)
        {
            //設定新增文章的新增者為登入者
            Data.Account = User.Identity.Name;
            //使用Service來新增一筆資料
            articleService.Insert(Data);
            //重新導向頁面至開始頁面
            return RedirectToAction("Index");
        }
        #endregion

        #region 修改文章
        //修改文章頁面要根據傳入編號來決定要修改的資料
        [Authorize] //設定此Action須登入
        public ActionResult Edit(int Id)
        {
            //取得頁面所需資料，藉由Service取得
            Article Data = articleService.GetDataById(Id);
            //將資料傳入View中
            return PartialView(Data);
        }

        //修改文章傳入資料時的Action
        [Authorize] //設定此Action須登入
        [HttpPost] //設定此Action只接受頁面POST資料傳入
        public ActionResult Edit(int Id, FormCollection FormValues)
        {
            //修改資料的是否可修改判斷
            if (articleService.CheckUpdate(Id))
            {
                //取得要修改的資料
                Article Data = articleService.GetDataById(Id);
                //使用Controller內建UpdateModel方法來修改資料
                //並限定修改的欄位屬性
                UpdateModel(Data, new string[] { "Content" });
                //儲存資料庫變更
                articleService.Save();
            }
            //重新導向頁面至文章頁面
            return RedirectToAction("Article", new { Id = Id });
        }
        #endregion

        #region 刪除文章
        //刪除文章要根據傳入編號來刪除資料
        [Authorize(Roles = "Admin")] //設定此Action只有Admin角色才可使用
        public ActionResult Delete(int Id)
        {
            articleService.Delete(Id); //使用Service來刪除資料
            return RedirectToAction("Index"); //重新導向頁面至開始頁面
        }
        #endregion

        #region 顯示人氣
        public ActionResult ShowPopularity()
        {
            //宣告一個新頁面模型
            ArticleView Data = new ArticleView();
            //取得頁面所需的人氣資料陣列
            Data.DataList = articleService.GetPopularityDataList();
            //將資料傳入View中
            return View(Data);
        }
        #endregion
    }
}