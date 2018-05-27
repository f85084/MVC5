$(function () {
    //呼叫物件的hide函式隱藏物件
    $('.subTreeList').hide();
    //綁定物件的點擊事件
    $('.TreeIcon').click(function () {
        //建立$this變數，並將觸發事件的物件使用$this變數儲存
        var $this = $(this);
        //呼叫物件的toggleClass函式，判斷物件有無'TreeIcon_open'的class屬性
        //若物件有該屬性，將此class屬性移除，相當於removeClass方法
        //若物件無該屬性，則為物件新增class屬性，相當於addClass方法
        $this.toggleClass('TreeIcon_open');
        //針對該物件下的ul呼叫slideToggle方法，若在slideToggle後加入function
        //則該function為callback
        $this.nextAll('ul').slideToggle(100, function (e) {
            //若物件可透過.TreeIcon_open選擇，則標示該物件包含TreeIcon_open的class屬性
            if ($this.is('.TreeIcon_open')) {
                //在物件中新增-的文字
				$this.text('-');
			}
            else {
                //在物件中新增+的文字
				$this.text('+');
			}
		})
	});
});