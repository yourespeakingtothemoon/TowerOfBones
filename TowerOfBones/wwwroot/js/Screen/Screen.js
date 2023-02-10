function Screen(tileNumbers) {
    this.tiles = []; // holds all tile objects

    this.setup = function () {
        for (let i = 0; i < tileNumbers.length; i++) {
            this.tiles[i] = []; // i hate this
            for (let j = 0; j < tileNumbers[i].length; j++) {
                this.tiles[i][j] = new Tile(createVector(j * 50, i * 50), createVector(50, 50), null, null, tileNumbers[i][j]);
            }
        }
    }

    this.show = function () {
        for (let i = 0; i < this.tiles.length; i++) {
            for (let j = 0; j < this.tiles[i].length; j++) {
                this.tiles[i][j].show();
            }
        }
    }

    this.moveTiles = function (ammount) {
        for (let i = 0; i < this.tiles.length; i++) {
            for (let j = 0; j < this.tiles[i].length; j++) {
                this.tiles[i][j].position.x += ammount.x;
                this.tiles[i][j].position.y += ammount.y;
            }
        }
    }
}