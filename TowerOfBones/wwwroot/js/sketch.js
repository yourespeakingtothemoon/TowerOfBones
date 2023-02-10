function setup() {
    createCanvas(800, 600);
    GameManager = new GameManger();
    GameManager.setup();
}

function draw() {
    background(51);
    GameManager.update();
}