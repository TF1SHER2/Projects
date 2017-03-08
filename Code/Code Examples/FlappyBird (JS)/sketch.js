var bird;
var pipes = [];
var paused = 1;
var score = 0;
function setup()
{
    createCanvas(400, 550);
    bird = new Bird();
    pipes.push(new Pipe());
}

function draw()
{
    background(55);

    //go through the array backwards, so you don't miss an index when a
    //pipe gets deleted
    for (var i = pipes.length - 1; i > 0; i--)
    {
        pipes[i].show();
        pipes[i].update();

        if (pipes[i].collides(bird))
        {
            score = score - 500;
        }
        //get rid of offscreen pipes
        if (pipes[i].offscreen())
        {
            pipes.splice(i, 1);
        }
    }
    bird.show();
    bird.update();

    //put a new pipe in the array every 100 frames
    if (frameCount % 100 == 0)
    {
        pipes.push(new Pipe());
    }

    if (frameCount % 2 == 0)
    {
        score++;
    }
    console.log("Your score is: " + score);

}

function keyPressed()
{
    if (key == ' ')
    {
        bird.launch();
    }
    if (keyCode === ESCAPE)
    {
        paused = -paused;
        if (paused == 1)
        {
            noLoop();
        }
        else
        {
            loop();
        }
    }
}
