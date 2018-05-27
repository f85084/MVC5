
//document ready事件
$(function() {
	//keydown事件
	$('#myText').keydown(function(e) {
		$('body').append('<p>這裡是keydown!鍵盤碼為:' + e.which + '，值為:' + String.fromCharCode(e.which) + '</p>');
	});
	//keypress事件
	$('#myText').keypress(function(e) {
		$('body').append('<p>這裡是keypress!鍵盤碼為:' + e.which + '，值為:' + String.fromCharCode(e.which) + '</p>');
	});
	//keyup事件
	$('#myText').keyup(function(e) {
		$('body').append('<p>這裡是keyup!鍵盤碼為:' + e.which + '，值為:' + String.fromCharCode(e.which) + '</p>');
	});
});