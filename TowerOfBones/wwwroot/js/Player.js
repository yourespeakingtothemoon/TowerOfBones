function Player(position) {
    this.position = position;
    this.size = createVector(50, 100)
    this.velocity = createVector(0, 0, 0);
    this.terminalVelocity = createVector(0, 0.2);
    this.colliding = new Vector4(false, false, false, false);
    this.onSurface = new Vector4(false, false, false, false);

    this.show = function () {
        fill(255);
        rect(this.position.x, this.position.y, this.size.x, this.size.y);
    }

    this.update = function () {
        //     if(!this.colliding.u || !this.colliding.r || !this.colliding.d || !this.colliding.l)
        //       {
        //         this.velocity = createVector(this.velocity.x * 0.8, this.velocity.y + this.terminalVelocity.y);
        //         constrain(this.velocity.y, -100, 5);
        //       }
        //     else
        //       {
        //         this.velocity = createVector(this.velocity.x * 0.8, 0);
        //       }
        //     if(keyIsDown(UP_ARROW) && !this.colliding.u)
        //       {
        //         if(!this.colliding.u)
        //           {
        //             this.velocity.y = -5;
        //           }

        //       }
        //     if(keyIsDown(LEFT_ARROW) && !this.colliding.l)
        //       {
        //         this.velocity.x -= 1;
        //       }
        //     if(keyIsDown(RIGHT_ARROW) && !this.colliding.r)
        //       {
        //         this.velocity.x += 1;
        //         //console.log(this.colliding.a + " " + this.colliding.y);
        //       }

        //     if (this.colliding.d)
        //       {
        //         this.velocity.y = constrain(this.velocity.y, -100, -0.2);
        //       }
        //     if (this.colliding.u)
        //       {
        //         this.velocity.y = constrain(this.velocity.y, -100, 0.2);
        //       }
        //     if (this.colliding.r)
        //       {

        //         this.velocity.x = constrain(this.velocity.x, -100, -0.2);
        //       }
        //     if (this.colliding.l)
        //       {
        //         this.velocity.x = constrain(this.velocity.x, 0.2, 100);
        //       }

        //     if(this.velocity.y < 0 && this.velocity.y > -0.2)
        //       {
        //         this.velocity.y = 0;
        //       }
        //     this.velocity.x = constrain(this.velocity.x, -5, 5)
        //     this.position.x += this.velocity.x;
        //     this.position.y += this.velocity.y;
        this.velocity = createVector(0, constrain(this.velocity.y, 0, 15));
        if (!this.onSurface.d) {
            this.velocity.y += 0.3;
            //this.position.y += 3;
        }
        else {
            this.velocity.y = 0;
        }
        if (keyIsDown(UP_ARROW) && (!this.onSurface.u)) {
            this.velocity.y = -20;
            //this.position.y -= 20
        }

        this.position.y += this.velocity.y

        // reset the onSurface
        if (!this.colliding.d) {
            this.onSurface.d = false;
        }
        if (!this.colliding.u) {
            this.onSurface.u = false;
        }
        if (!this.colliding.l) {
            this.onSurface.l = false;
        }
        if (!this.colliding.r) {
            this.onSurface.r = false;
        }
        this.position.x = constrain(this.position.x, 0, 750);
        this.position.y = constrain(this.position.y, 0, 500);
    }

    this.move = function () {
        if (keyIsDown(RIGHT_ARROW) && !this.onSurface.r) {
            this.position.x += 7;
        }
        if (keyIsDown(LEFT_ARROW) && !this.onSurface.l) {
            this.position.x -= 7;
        }
    }

    this.isInCenter = function () {
        if (this.position.x >= 395 && this.position.x <= 405) {
            return true;
        }
        return false;
    }

    // move the player to the surface of the object
    this.putOnSurface = function (distance, dir) {
        if (dir === 'd' && abs(distance) <= 10) {
            this.position.y += distance;
            this.onSurface.d = true;
        }
        if (dir === 'r' && abs(distance) <= 10) {
            this.position.x += distance;
            this.onSurface.r = true;
        }
        if (dir === 'l' && abs(distance) <= 10) {
            this.position.x -= distance;
            this.onSurface.l = true;
        }
        if (dir === 'u' && abs(distance) < 30) {
            this.position.y -= distance;
            this.onSurface.l = true;
        }
    }
}