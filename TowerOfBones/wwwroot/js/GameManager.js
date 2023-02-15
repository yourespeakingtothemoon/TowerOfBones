function GameManger() {
  this.ScreenManager = new ScreenManager();
  this.player = new Player(createVector(100, 350));

  this.setup = function () {
    this.ScreenManager.setup();
  };

  this.update = function () {
    this.ScreenManager.update();
    this.ScreenManager.show();
    this.player.update();
    this.player.colliding = new Vector4(false, false, false, false);
    for (let i = 0; i < this.ScreenManager.CurrentScreen.tiles.length; i++) {
      for (let j = 0; j < this.ScreenManager.CurrentScreen.tiles[i].length; j++) {
        if (this.ScreenManager.CurrentScreen.tiles[i][j].solid) {
          if (boxCollision(this.player, this.ScreenManager.CurrentScreen.tiles[i][j], 1)) 
          {
            this.player.colliding = collisionDirection(this.player, this.ScreenManager.CurrentScreen.tiles[i][j]);
          } 
          if(boxCollision(this.player, this.ScreenManager.CurrentScreen.tiles[i][j], 0))
            {
              if(this.player.colliding.d)
                {
                  this.player.putOnSurface(distanceFromSurface(this.player, this.ScreenManager.CurrentScreen.tiles[i][j], 'd'), 'd');
                }
            if(this.player.colliding.u)
              {
                this.player.putOnSurface(distanceFromSurface(this.player, this.ScreenManager.CurrentScreen.tiles[i][j], 'u'), 'u');
              }
            if(this.player.colliding.r)
              {
                this.player.putOnSurface(distanceFromSurface(this.player, this.ScreenManager.CurrentScreen.tiles[i][j], 'r'), 'r');
              }
            if(this.player.colliding.l)
              {
                this.player.putOnSurface(distanceFromSurface(this.player, this.ScreenManager.CurrentScreen.tiles[i][j], 'l'), 'l');
              }
            }
        }
      }
    }
    if(this.ScreenManager.onEdge())
      {
        this.player.move();
      }
    if (this.player.isInCenter())
      {
        this.ScreenManager.move();
      }
    this.player.show();
  };
}
