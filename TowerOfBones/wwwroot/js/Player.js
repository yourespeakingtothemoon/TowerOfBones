class Player {
    constructor(position) {
        this.position = position;
    }

    show() {
        fill(255);
        rect(this.position.x, this.position.y, 50, 100);
    }

    update() {
        if (keyCode == 38) {
            this.position.y -= 10;
        }
        if (keyCode == 40) {
            this.position.y += 10;
        }
        if (keyCode == 37) {
            this.position.x -= 10;
        }
        if (keyCode == 39) {
            this.position.x += 10;
        }
    }
}