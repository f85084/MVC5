$(function(){
	var _showTabInd = 0;
	$(".myTab").each(function(index, element) {
        var $tab = $(this);
		//綁定物件的click事件
        $('.tab_header a', $tab).click(function (e) {
            //建立$this變數，並將觸發事件的物件使用$this變數儲存
            var $this = $(this),
                //建立_showTab變數，並呼叫物件的attr方法取得其href屬性
				_showTab = $($this.attr('href')),
                //建立_oldTabLink變數，儲存物件
				_oldTabLink = $('.tab_header a.active'),
                //建立_oldTab變數，並呼叫物件的attr方法取得其href屬性
				_oldTab = $(_oldTabLink.attr('href'));
            //呼叫_oldTabLink的removeClass方法，移除class屬性
            _oldTabLink.removeClass('active');
            //將_oldTab物件顯示，並呼叫slideToggle方法，使用下滑的方式顯示
            _oldTab.show().slideToggle();
            //給予物件class屬性
            $this.addClass('active');
            //將_showTab物件隱藏，並呼叫slideToggle方法，使用上滑的方式隱藏
			_showTab.hide().slideToggle();
			
            //透過preventDefault事件，阻止物件發生自行默認的事件
			e.preventDefault();
			return false;
		});
	    //呼叫物件的hide方法，隱藏物件
        $('.tab_content', $tab).hide();
	    //呼叫物件中_showTabInd的click事件
		$('.tab_header a', $tab).eq(_showTabInd).click();
		
    });
});