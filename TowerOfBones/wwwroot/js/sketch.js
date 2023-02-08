let tiles = [];
let player;

function setup() // essentialy unity start
{
    createCanvas(800, 600);
    player = new Player(createVector(100, 100));
    for (let e = 0; e < 16; e++) {
        tiles[e] = []
    }
    for (let i = 0; i < 16; i++) {
        for (let j = 0; j < 12; j++) {
            tiles[i][j] = new Tile(createVector(i * 50, j * 50), createVector(50, 50), "owo", null);
        }
    }
}

function draw() // essentailly unity update
{
    background(51);
    for (let i = 0; i < 16; i++) {
        for (let j = 0; j < 12; j++) {
            tiles[i][j].show();
        }
    }
    player.update();
    player.show();

}