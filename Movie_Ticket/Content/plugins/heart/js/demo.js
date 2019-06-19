;(function(window) {

	'use strict';

	// taken from mo.js demos
	function isIOSSafari() {
		var userAgent;
		userAgent = window.navigator.userAgent;
		return userAgent.match(/iPad/i) || userAgent.match(/iPhone/i);
	};

	// taken from mo.js demos
	function isTouch() {
		var isIETouch;
		isIETouch = navigator.maxTouchPoints > 0 || navigator.msMaxTouchPoints > 0;
		return [].indexOf.call(window, 'ontouchstart') >= 0 || isIETouch;
	};
	
	// taken from mo.js demos
	var isIOS = isIOSSafari(),
		clickHandler = isIOS || isTouch() ? 'touchstart' : 'click';

	function extend( a, b ) {
		for( var key in b ) { 
			if( b.hasOwnProperty( key ) ) {
				a[key] = b[key];
			}
		}
		return a;
	}

	function Animocon(el, options) {
		this.el = el;
		this.options = extend( {}, this.options );
		extend( this.options, options );

		this.checked = false;

		this.timeline = new mojs.Timeline();
		
		for(var i = 0, len = this.options.tweens.length; i < len; ++i) {
			this.timeline.add(this.options.tweens[i]);
		}

		var self = this;
		this.el.addEventListener(clickHandler, function() {
			if( self.checked ) {
				self.options.onUnCheck();
			}
			else {
				self.options.onCheck();
				self.timeline.start();
			}
			self.checked = !self.checked;
		});
	}

	Animocon.prototype.options = {
		tweens : [
			new mojs.Burst({
				shape : 'circle',
				isRunLess: true
			})
		],
		onCheck : function() { return false; },
		onUnCheck : function() { return false; }
	};

	// grid items:
	var items = [].slice.call(document.querySelectorAll('.casasas'));

	function init() {
	


		/* Icon 16 */
		var el16 = items[0].querySelector('button.icobutton'), el16span = el16.querySelector('span');
		var opacityCurve16 = mojs.easing.path('M0,0 L25.333,0 L75.333,100 L100,0');
		var translationCurve16 = mojs.easing.path('M0,100h25.3c0,0,6.5-37.3,15-56c12.3-27,35-44,35-44v150c0,0-1.1-12.2,9.7-33.3c9.7-19,15-22.9,15-22.9');
		var squashCurve16 = mojs.easing.path('M0,100.004963 C0,100.004963 25,147.596355 25,100.004961 C25,70.7741867 32.2461944,85.3230873 58.484375,94.8579105 C68.9280825,98.6531013 83.2611815,99.9999999 100,100');
		new Animocon(el16, {
			tweens : [
				// burst animation (circles)
				new mojs.Burst({
					parent: el16,
					duration: 1700,
					delay: 350,
					shape : 'circle',
					fill: '#FF6767',
					x: '50%',
					y: '50%',
					opacity: 0.3,
					childOptions: { radius: {'rand(15,5)':0} },
					radius: {0:150},
					degree: 50,
					angle: -25,
					count: 6,
					isRunLess: true,
					easing: mojs.easing.bezier(0.1, 1, 0.3, 1)
				}),
				// burst animation (line1)
				new mojs.Burst({
					parent: el16,
					duration: 600,
					delay: 200,
					shape : 'circle',
					fill: '#C0C1C3',
					x: '20%',
					y: '100%',
					childOptions: { 
						radius: {60:0},
						type: 'line',
						stroke: '#FF6767',
						strokeWidth: 2,
						strokeLinecap: 'round'
					},
					radius: {50:180},
					angle: 180,
					count: 1,
					opacity: 0.4,
					isRunLess: true,
					easing: mojs.easing.bezier(0.1, 1, 0.3, 1)
				}),
				// burst animation (line2)
				new mojs.Burst({
					parent: el16,
					duration: 600,
					delay: 200,
					shape : 'circle',
					fill: '#C0C1C3',
					x: '50%',
					y: '100%',
					childOptions: { 
						radius: {60:0},
						type: 'line',
						stroke: '#FF6767',
						strokeWidth: 2,
						strokeLinecap: 'round'
					},
					radius: {50:220},
					angle: 180,
					count: 1,
					opacity: 0.4,
					isRunLess: true,
					easing: mojs.easing.bezier(0.1, 1, 0.3, 1)
				}),
				// burst animation (line3)
				new mojs.Burst({
					parent: el16,
					duration: 600,
					delay: 200,
					shape : 'circle',
					fill: '#C0C1C3',
					x: '80%',
					y: '100%',
					childOptions: { 
						radius: {60:0},
						type: 'line',
						stroke: '#FF6767',
						strokeWidth: 2,
						strokeLinecap: 'round'
					},
					radius: {50:180},
					angle: 180,
					count: 1,
					opacity: 0.4,
					isRunLess: true,
					easing: mojs.easing.bezier(0.1, 1, 0.3, 1)
				}),
				// icon scale animation
				new mojs.Tween({
					duration : 500,
					onUpdate: function(progress) {
						var translateProgress = translationCurve16(progress),
							squashProgress = squashCurve16(progress),
							scaleX = 1 - 2*squashProgress,
							scaleY = 1 + 2*squashProgress;

						el16span.style.WebkitTransform = el16span.style.transform = 'translate3d(0,' + -180*translateProgress + 'px,0) scale3d(' + scaleX + ',' + scaleY + ',1)';

						var opacityProgress = opacityCurve16(progress);
						el16span.style.opacity = opacityProgress;

						el16.style.color = progress >= 0.75 ? '#FF6767' : '#C0C1C3';
					}
				})
			],
			onUnCheck : function() {
				alert("Zaten Beğendin :D ");
			}
		});
		/* Icon 16 */

		
	
	}
	
	init();

})(window);