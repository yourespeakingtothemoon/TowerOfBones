function Tile(position, size, imageName, imageLocation, type) {
    this.position = position;
    this.size = size;
    this.imageName = imageName;
    this.imageLocation = imageLocation;
    this.type = type;
    this.solid = false;

    this.show = function () {
        switch (type) // type corrisponds with the numbers on screens
        {
            case 0:
                fill(20, 20, 100);
                break;
            case 1:
                fill(20, 100, 20);
                this.solid = true;
                break;
        }
        // will be changed to work with images eventually
        rect(this.position.x, this.position.y, this.size.x, this.size.y);
    }
}