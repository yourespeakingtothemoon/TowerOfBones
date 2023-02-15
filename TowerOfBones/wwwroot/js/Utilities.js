
function boxCollision(thing1, thing2, tollerence = 0) {
    if (!(thing1.position.x - tollerence >= thing2.position.x + thing2.size.x || // if object1 is to the right of object2
        thing1.position.x + thing1.size.x + tollerence <= thing2.position.x || // if object1 is to the left object2
        thing1.position.y - tollerence >= thing2.position.y + thing2.size.y || // if object1 is below object2
        thing1.position.y + thing1.size.y + tollerence <= thing2.position.y)) {// if object1 is above object2
        return true;
    } else {
        return false;
    }
}

// this should only be used for if we already know that the two objects are colliding
function collisionDirection(thing1, thing2) {
    let colVector = new Vector4(false, false, false, false);
    if (thing1.position.x > thing2.position.x + thing2.size.x / 2) {
        colVector.l = true;
    }
    if (thing1.position.x + thing1.size.x < thing2.position.x + thing2.size.x / 2) {
        colVector.r = true;
    }
    if (thing1.position.y > thing2.position.y + thing2.size.y / 2) {
        colVector.u = true;
    }
    if (thing1.position.y + thing1.size.y < thing2.position.y + thing2.size.y / 2) {
        colVector.d = true;
    }
    return colVector;
}

function distanceFromSurface(thing1, thing2, dir) {
    switch (dir) {
        case 'u':
            return thing1.position.y - (thing2.position.y + thing2.size.y);
        case 'r':
            return -(thing1.position.x + thing1.size.x - thing2.position.x);
        case 'd':
            return -(thing1.position.y + thing1.size.y - thing2.position.y);
        case 'l':
            return thing1.position.x - (thing2.position.x + thing2.size.x);
    }
}

function Vector4(u, r, d, l) {
    this.u = u; // up
    this.r = r; // right
    this.d = d; // down
    this.l = l; // left
}

// this basically just removes the default use of the arrow keys and the space bar while the canvas is selected
// allows for the website to be larger 
var arrow_keys_handler = function (e) {
    switch (e.keyCode) {
        case 37:
        case 39:
        case 38:
        case 40: // Arrow keys
        case 32:
            e.preventDefault();
            break; // Space
        default:
            break; // do not block other keys
    }
};
