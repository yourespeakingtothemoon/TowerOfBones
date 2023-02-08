function ScreenManager() {
    this.ScreenTiles = [];
    this.Screens = [];
    this.CurrentScreen = null;

    this.setup = function () {
        for (let i = 0; i < screens.length; i++) {
            this.ScreenTiles[i] = screens[i];
            this.Screens[i] = new Screen(this.ScreenTiles[i].tiles, this.ScreenTiles[i].name);
            this.Screens[i].setup();
        }
        this.CurrentScreen = this.Screens[1];
    }

    this.show = function () {
        this.CurrentScreen.show();
    }
}