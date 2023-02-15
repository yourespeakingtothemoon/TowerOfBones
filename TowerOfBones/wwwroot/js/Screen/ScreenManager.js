function ScreenManager() {
    this.ScreenTiles = []; // containter for all screens json objects
    this.CurrentScreen = null;

    this.setup = function () {
        this.randomizeLevel();
        this.CurrentScreen.setup();
    }

    this.show = function () {
        this.CurrentScreen.show();
    }

    // this will need to be changed to work with the game manager
    this.update = function () {
        if (keyIsDown(LEFT_ARROW)) {
            //this.CurrentScreen.moveTiles(createVector(7, 0));
        }
        if (keyIsDown(RIGHT_ARROW)) {
            //this.CurrentScreen.moveTiles(createVector(-7, 0));
        }
        if (keyIsDown(32)) {
            console.log(this.CurrentScreen.tiles[0][0].position.x)
            console.log(this.CurrentScreen.tiles[0][this.CurrentScreen.tiles[0].length - 1].position.x);
        }
    }

    this.move = function () {
        if (keyIsDown(RIGHT_ARROW) && this.CurrentScreen.tiles[0][this.CurrentScreen.tiles[0].length - 1].position.x != 750) {
            this.CurrentScreen.moveTiles(createVector(-5, 0));
        }
        if (keyIsDown(LEFT_ARROW) && this.CurrentScreen.tiles[0][0].position.x != 0) {
            this.CurrentScreen.moveTiles(createVector(5, 0));
        }
    }

    this.onEdge = function () {
        if (this.CurrentScreen.tiles[0][0].position.x == 0 ||
            this.CurrentScreen.tiles[0][this.CurrentScreen.tiles[0].length - 1].position.x == 750) {
            return true;
        }
    }

    // creates the floor from all of the screens
    this.randomizeLevel = function () {
        let length = floor(random(2, 4)); // how many screens long
        let screen = 0; // used for the randomization
        let randomScreenTiles = []; // final array of tile numbers

        // the stupid javascript thing where you cant make a 2d array normally 
        for (let i = 0; i < screens[screen].tiles.length; i++) {
            randomScreenTiles[i] = [];
        } // all screens will need to be the same hight


        for (let l = 0; l < length; l++) {
            for (let i = 0; i < screens[screen].tiles.length; i++) {
                for (let j = 0; j < screens[screen].tiles[i].length; j++) {
                    // the only way that i can think to add on to an existing 2d array
                    append(randomScreenTiles[i], screens[screen].tiles[i][j]);
                }
            }
            if (!screens[screen].IsEnd) {
                // find the next screen from the children screens
                screen = screens[screen].Children[floor(random(screens[screen].Children.length))].position;
            }
            else {
                break;
            }
        }
        // create the screen from the tile numbers
        this.CurrentScreen = new Screen(randomScreenTiles);
    }
}