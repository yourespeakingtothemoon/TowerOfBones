function Player(position) {
    this.position = position;
    this.velocity = createVector(0, 0, 0);

    this.show = function () {
        fill(255);
        rect(this.position.x, this.position.y, 50, 100);
    }

    this.update = function () {
        this.velocity = createVector(this.velocity.x * 0.8, 1);
        if (keyIsDown(UP_ARROW)) {
            this.velocity.y -= 10;
        }
        if (keyIsDown(LEFT_ARROW)) {
            this.velocity.x -= 1;
        }
        if (keyIsDown(RIGHT_ARROW)) {
            this.velocity.x += 1;
        }
        this.position.x += this.velocity.x;
        this.position.y += this.velocity.y;
    }
}