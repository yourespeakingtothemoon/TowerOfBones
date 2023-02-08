function setup() {
    createCanvas(800, 600);
    GameManager = new GameManger(null, null);
    GameManager.setup();
}

function draw() {
    background(51);
    GameManager.update();
}