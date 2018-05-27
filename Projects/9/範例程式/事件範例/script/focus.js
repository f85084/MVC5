
//document ready事件
$(function() {
	//區塊的focus事件
	$('#myblock').focus(function(e) {
		$('body').append('<p>這裡是區塊的focus!</p>');
	});
	//區塊的focusin事件
	$('#myblock').focusin(function(e) {
		$('body').append('<p>這裡是區塊的focusin!</p>');
	});
	//區塊的focusout事件
	$('#myblock').focusout(function(e) {
		$('body').append('<p>這裡是區塊的focusout!</p>');
	});
	//區塊的blur事件
	$('#myblock').blur(function(e) {
		$('body').append('<p>這裡是區塊的blur!</p>');
	});
	//輸入框的focus事件
	$('#myText').focus(function(e) {
		$('body').append('<p>這裡是輸入框的focus!</p>');
	});
	//輸入框的focusin事件
	$('#myText').focusin(function(e) {
		$('body').append('<p>這裡是輸入框的focusin!</p>');
	});
	//輸入框的focusout事件
	$('#myText').focusout(function(e) {
		$('body').append('<p>這裡是輸入框的focusout!</p>');
	});
	//輸入框的blur事件
	$('#myText').blur(function(e) {
		$('body').append('<p>這裡是輸入框的blur!</p>');
	});
});