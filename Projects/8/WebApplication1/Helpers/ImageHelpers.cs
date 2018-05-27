using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Helpers
{
    public static class ImageHelpers
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string src, string alt)
        {
            //設定輸出的HTML標籤
            return MvcHtmlString.Create(String.Format("<img src='{0}' alt='{1}' />", src, alt));
        }

        public static MvcHtmlString Image(this HtmlHelper helper, string id, string src, string alt)
        {
            //產生新的 TagBuilder 物件
            var builder = new TagBuilder("img");

            //賦予其 id 值
            builder.GenerateId(id);

            //附加屬性
            builder.MergeAttribute("src", src);
            builder.MergeAttribute("alt", alt);

            //輸出
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }

    }

}