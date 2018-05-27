
//document ready事件
$(function () {
    //宣告oldValue變數並給予初始值
	var oldValue = '';
	//註冊change事件
	$('#myText').change(function (e) {
	    //宣告value變數，並將觸發事件的input內容儲存於變數中
		var value = $(this).val();
		$('#myblock').html('舊的值為:' + oldValue + '<br />新的值為:' + value);
		oldValue = value;
	});
});