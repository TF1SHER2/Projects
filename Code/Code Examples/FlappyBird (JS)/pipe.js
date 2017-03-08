function Pipe()
{
    //top is the rectangle on top's length, bottom is for the rectanlge on bottom
    //also ensures there is always adequate space in the middle, and that each pipe
    //has a decent length
    this.top = height*random((3/12), (5/12));
    this.bottom = height - (height*random((7/12), (9/12)));
    this.x = width;
    this.w = 20;
    this.speed = 2;
    this.highlight = false;

    this.collides = function(bird)
    {
        //check the y coords of the bird against that of the pipe
        if ((bird.y < this.top) || (bird.y > height - this.bottom))
        {
            //make sure the bird is within the width of the pipe as well
            if ((bird.x > this.x) && (bird.x < this.x + this.w))
            {
                this.highlight = true;
                return true;
            }
        }
        return false;
        this.hightlight = false;
    }
    this.show = function()
    {
        fill(255);
        //highlights the pipes red if highlight is true
        if (this.highlight)
        {
            fill(255, 0, 0);
            noLoop();
        }
        rect(this.x, 0, this.w, this.top);
        rect(this.x, height-this.bottom, this.w, this.bottom);
    }

    this.update = function()
    {
        this.x -= this.speed;
    }

    //returns true if a pipe is off the screen
    this.offscreen = function()
    {
        if (this.x < -this.w)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
