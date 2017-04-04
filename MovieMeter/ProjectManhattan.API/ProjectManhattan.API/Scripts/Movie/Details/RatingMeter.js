﻿var drawGraph = function(DomId) {
    var el = document.getElementById(DomId); // get canvas
    while (el.firstChild) {
        el.removeChild(el.firstChild);
    }
    var options = {
        percent: el.getAttribute('data-percent'),
        size: el.getAttribute('data-size') || 220,
        lineWidth: el.getAttribute('data-line') || 15,
        rotate: el.getAttribute('data-rotate') || 0
    }
    alert(el.parentElement.style.width);
    options.size = (el.parentElement.parentElement.offsetWidth / 1.2);
    options.lineWidth = options.size / 14.6;
    var canvas = document.createElement('canvas');
    var span = document.createElement('span');
    span.textContent = options.percent + '%';
    span.style.lineHeight = span.style.width = Math.round(options.size) + "px";
    span.style.fontSize = Math.round(options.size / 5) + "px";
    if (typeof (G_vmlCanvasManager) !== 'undefined') {
        G_vmlCanvasManager.initElement(canvas);
    }

    var ctx = canvas.getContext('2d');
    canvas.width = canvas.height = options.size;

    el.appendChild(span);
    el.appendChild(canvas);

    ctx.translate(options.size / 2, options.size / 2); // change center
    ctx.rotate((-1 / 2 + options.rotate / 180) * Math.PI); // rotate -90 deg

    //imd = ctx.getImageData(0, 0, 240, 240);
    var radius = (options.size - options.lineWidth) / 2;

    var drawCircle = function (color, lineWidth, percent) {
        percent = Math.min(Math.max(0, percent || 1), 1);
        ctx.beginPath();
        ctx.arc(0, 0, radius, 0, Math.PI * 2 * percent, false);
        ctx.strokeStyle = color;
        ctx.lineCap = 'round'; // butt, round or square
        ctx.lineWidth = lineWidth
        ctx.stroke();
    };

    drawCircle('#efefef', options.lineWidth, 100 / 100);
    drawCircle('#555555', options.lineWidth, options.percent / 100);
};