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

    this.update = function () {
        if (keyIsDown(LEFT_ARROW)) {
            this.CurrentScreen.moveTiles(createVector(5, 0));
        }
        if (keyIsDown(RIGHT_ARROW)) {
            this.CurrentScreen.moveTiles(createVector(-5, 0));
        }
    }

    this.randomizeLevel = function () {
        let length = floor(random(2, 4)); // how many screens long
        let screen = 0;
        let randomScreenTiles = [];
        for (let i = 0; i < screens[screen].tiles.length; i++) {
            randomScreenTiles[i] = [];
        } // all screens will need to be the same hight
        for (let l = 0; l < length; l++) {
            for (let i = 0; i < screens[screen].tiles.length; i++) {
                for (let j = 0; j < screens[screen].tiles[i].length; j++) {
                    append(randomScreenTiles[i], screens[screen].tiles[i][j]);
                }
            }
            if (!screens[screen].IsEnd) {
                screen = screens[screen].Children[floor(random(screens[screen].Children.length))].position;
            }
            else {
                break;
            }
        }
        //console.log(randomScreenTiles);
        this.CurrentScreen = new Screen(randomScreenTiles);
        //console.log(this.CurrentScreen);
    }
}