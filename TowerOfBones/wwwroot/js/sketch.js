function setup() {
    createCanvas(800, 600);
    GameManager = new GameManger();
    GameManager.setup();
    //frameRate(60);
}

function draw() {
    background(51);
    GameManager.update();
}