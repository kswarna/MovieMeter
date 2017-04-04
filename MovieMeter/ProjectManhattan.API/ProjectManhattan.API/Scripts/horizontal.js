jQuery(function($){
	'use strict';

	// -------------------------------------------------------------
	//   Force Centered Navigation
	// -------------------------------------------------------------
	(function () {
		var $frame = $('#forcecentered');
		var $wrap  = $frame.parent();

		// Call Sly on frame
		$frame.sly({
			horizontal: 1,
			itemNav: 'forceCentered',
			smart: 1,
			activateMiddle: 1,
			activateOn: 'click',
			mouseDragging: 1,
			touchDragging: 1,
			releaseSwing: 1,
			startAt: 0,
			scrollBar: $wrap.find('.scrollbar'),
			scrollBy: 1,
			speed: 300,
			elasticBounds: 1,
			easing: 'easeOutExpo',
			dragHandle: 1,
			dynamicHandle: 1,
			clickBar: 1,

			// Buttons
			prev: $wrap.find('.prev'),
			next: $wrap.find('.next')
		});
		var $frame2 = $('#forcecentered2');
		var $wrap2 = $frame.parent();

	    // Call Sly on frame
		$frame2.sly({
		    horizontal: 1,
		    itemNav: 'forceCentered',
		    smart: 1,
		    activateMiddle: 1,
		    activateOn: 'click',
		    mouseDragging: 1,
		    touchDragging: 1,
		    releaseSwing: 1,
		    startAt: 0,
		    scrollBar: $wrap2.find('#csSb'),
		    scrollBy: 1,
		    speed: 300,
		    elasticBounds: 1,
		    easing: 'easeOutExpo',
		    dragHandle: 1,
		    dynamicHandle: 1,
		    clickBar: 1,

		    // Buttons
		    prev: $wrap2.find('#csprev'),
		    next: $wrap2.find('#csNext')
		});
	}());
});