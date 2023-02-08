function GameManger() {
    this.ScreenManager = new ScreenManager();
    this.player = new Player(createVector(100, 100));

    this.setup = function () {
        this.ScreenManager.setup();
    }

    this.update = function () {
        this.ScreenManager.show();
        this.player.update();
        this.player.show();
    }
}