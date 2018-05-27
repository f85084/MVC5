$(function () {
    var _showTabInd = 0;
    //透過each方法，規範每個物件皆須綁定的動作
	$(".MenuBar").each(function(index, element) {
        var $menu = $(this);
	    //hover函式包含滑鼠移入mouseover及mouseout事件
        //第一個function部分為mouseover事件
        $("li:not(ul.SubMenu li)", $menu).hover(function (e) {
            //建立$this變數，並將觸發事件的物件使用$this變數儲存
		    var $this = $(this),
                //建立_subMenu變數，透過find函式搜尋$this變數中的'ul.SubMenu'物件
                //同時將該物件使用_subMenu變數儲存
			 	_subMenu = $this.find('ul.SubMenu');
            //呼叫_subMenu物件的slideToggle函式，若該物件為隱藏時，使用下滑的方式顯示
            //slideToggle函式中可傳入一數字做為speed參數，控制下滑的速度。
		    _subMenu.slideToggle(50);
        //第二個function部分為mouseout事件
        }, function (e) {
            //建立$this變數，並將觸發事件的物件使用$this變數儲存
            var $this = $(this),
                //建立_subMenu變數，透過find函式搜尋$this變數中的'ul.SubMenu'物件
                //同時將該物件使用_subMenu變數儲存
			 	_subMenu = $this.find('ul.SubMenu');
            //呼叫_subMenu物件的slideToggle函式，若該物件為顯示時，使用上滑的方式縮小
            //slideToggle函式中可傳入一數字做為speed參數，控制上滑的速度。
			_subMenu.slideToggle(50);
		});
		//完成hover函式後，呼叫物件的hide函式隱藏物件，完成物件的初始化
		$('.SubMenu', $menu).hide();
		
    });
});