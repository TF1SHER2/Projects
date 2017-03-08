var angle = 0;

function setup()
{
    createCanvas(400, 400);
    slider = createSlider(0, TWO_PI, PI/4, 0.01);
}

function draw()
{

    background(204);
    angle = slider.value();
    var len = 100;
    var weight = 12;
    stroke(0);
    strokeWeight(weight);
    //translates the origin to the bottom of where the first branch will be
    translate(200, height);
    branch(len, weight);

}

function branch(len, weight)
{
    //because origin is translated here, the two points are (0,0), and (0, -len)
    line(0, 0, 0, -len);
    //translates the origin to the top of the line
    translate(0, -len);
    if (weight >1)
    {
        weight = weight*.75;
    }
    //if the length isn't too small, draw a new branch that is 2/3s the original's size
    if (len > 4)
    {
        push();
        strokeWeight(weight);
        //PI/4 is 45 degrees, p5 uses radians
        rotate(angle);
        branch(len*.67, weight);
        pop();
        push();
        strokeWeight(weight);
        rotate(-angle);
        branch(len*.67, weight);
        pop();
    }
}
