function Tile(position, size, imageName, imageLocation, type) {
    this.position = position;
    this.size = size;
    this.imageName = imageName;
    this.imageLocation = imageLocation;
    this.type = type;

    this.show = function () {
        switch (type) {
            case 0:
                fill(20, 20, 100);
                break;
            case 1:
                fill(20, 100, 20);
                break;
        }
        rect(this.position.x, this.position.y, this.size.x, this.size.y);
    }
}