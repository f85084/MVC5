
//document ready事件
$(function() {
	//區塊的點擊事件
	$('#myblock').click(function(e) {
		$('body').append('<p>您點擊區塊了!</p>');
	});
	//按鈕的點擊事件
	$('#mybtn').click(function(e) {
		$('body').append('<p>您點擊按鈕了!</p>');
	});
	//按鈕的雙擊事件
	$('#mybtn').dblclick(function(e) {
		$('body').append('<p>您雙擊按鈕了!</p>');
	});
	//按鈕的點擊起來事件
	$('#mybtn').mouseup(function(e) {
		$('body').append('<p>您點擊起來按鈕了!</p>');
	});
	//按鈕的按下事件
	$('#mybtn').mousedown(function(e) {
		$('body').append('<p>您按下按鈕了!</p>');
	});
});