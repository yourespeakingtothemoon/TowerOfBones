function Screen(tileNumbers, name) {
    this.tiles = [];
    this.name = name;

    this.setup = function () {
        for (let i = 0; i < tileNumbers.length; i++) {
            this.tiles[i] = [];
            for (let j = 0; j < tileNumbers[i].length; j++) {
                this.tiles[i][j] = new Tile(createVector(j * 50, i * 50), createVector(50, 50), null, null, tileNumbers[i][j]);
            }
        }
    }

    this.show = function () {
        for (let i = 0; i < this.tiles.length; i++) {
            for (let j = 0; j < this.tiles[0].length; j++) {
                this.tiles[i][j].show();
            }
        }
    }
}