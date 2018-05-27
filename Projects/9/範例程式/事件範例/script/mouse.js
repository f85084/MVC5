
//document ready事件
$(function() {
	//mouseenter事件
	$('#myblock').mouseenter(function(e) {
		$('body').append('<p>這裡是mouseenter!</p>');
	});
	//mouseover事件
	$('#myblock').mouseover(function(e) {
		$('body').append('<p>這裡是mouseover!</p>');
	});
	//mousemove事件
	$('#myblock').mousemove(function(e) {
		$('body').append('<p>這裡是mousemove!</p>');
	});
	//mouseleave事件
	$('#myblock').mouseleave(function(e) {
		$('body').append('<p>這裡是mouseleave!</p>');
	});
	//mouseout事件
	$('#myblock').mouseout(function(e) {
		$('body').append('<p>這裡是mouseout!</p>');
	});
});