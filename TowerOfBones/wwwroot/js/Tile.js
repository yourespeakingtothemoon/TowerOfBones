class Tile {
    constructor(position, size, image, imagepPosition) {
        this.position = position;
        this.size = size;
        this.image = image;
        this.imagepPosition = imagepPosition;
    }

    show() {
        fill(20, 100, 20)
        rect(this.position.x, this.position.y, this.size.x, this.size.y);
    }
}