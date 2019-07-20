﻿@code
End Code
<style>
    body {
        margin: 0px;
        overflow: hidden;
    }

    h3 {
        left: 50%;
        position: absolute;
        top: 50%;
        transform: translate( -50%, -50%);
        font-family: 'Molle', cursive;
        font-size: 3em;
        color: hsla(255, 255%, 255%, .1);
    }
</style>

<canvas id='canvas'></canvas>
<h3>Animated Snow 4</h3>

<script>
    var canvas = document.getElementById('canvas'),
        ctx = canvas.getContext("2d");
    var windowW = canvas.width = window.innerWidth,
        windowH = canvas.height = window.innerHeight;

    Snowy();
    function Snowy() {
        var snow,
            arr = [];
        var num = 600,
            tsc = 1,
            sp = 1;
        var sc = 1.3,
            t = 0,
            mv = 20,
            min = 1;

        for (var i = 0; i < num; ++i) {
            snow = new Flake();
            snow.y = Math.random() * (windowH + 50);
            snow.x = Math.random() * windowW;
            snow.t = Math.random() * (Math.PI * 2);
            snow.sz = (100 / (10 + (Math.random() * 100))) * sc;
            snow.sp = (Math.pow(snow.sz * .8, 2) * .15) * sp;
            snow.sp = snow.sp < min ? min : snow.sp;
            arr.push(snow);
        }
        go();

        function go() {
            window.requestAnimationFrame(go);
            ctx.clearRect(0, 0, windowW, windowH);
            //ctx.fillStyle = 'hsla(242, 95%, 3%, 1)';
            ctx.fillRect(0, 0, windowW, windowH);
            ctx.fill();
            for (var i = 0; i < arr.length; ++i) {
                f = arr[i];
                f.t += .05;
                f.t = f.t >= Math.PI * 2 ? 0 : f.t;
                f.y += f.sp;
                f.x += Math.sin(f.t * tsc) * (f.sz * .3);
                if (f.y > windowH + 50) f.y = -10 - Math.random() * mv;
                if (f.x > windowW + mv) f.x = - mv;
                if (f.x < - mv) f.x = windowW + mv;
                f.draw();
            }
        }
        function Flake() {
            this.draw = function () {
                this.g = ctx.createRadialGradient(this.x, this.y, 0, this.x, this.y, this.sz);
                this.g.addColorStop(0, 'hsla(255,255%,255%,1)');
                this.g.addColorStop(1, 'hsla(255,255%,255%,0)');
                ctx.moveTo(this.x, this.y);
                ctx.fillStyle = this.g;
                ctx.beginPath();
                ctx.arc(this.x, this.y, this.sz, 0, Math.PI * 2, true);
                ctx.fill();
            }
        }
    }

    /*________________________________________*/
    window.addEventListener('resize', function () {
        canvas.width = windowW = window.innerWidth;
        canvas.height = windowH = window.innerHeight;
    }, false);
</script>