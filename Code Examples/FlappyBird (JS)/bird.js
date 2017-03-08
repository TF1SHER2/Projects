function Bird()
{
    this.y = height/2;
    this.x = 64;
    this.gravity = .8;
    this.velocity = 0;

    this.show = function()
    {
        fill (255);
        ellipse(this.x, this.y, 32, 32);
    }

    this.update = function()
    {
        //makes gravity affect the bird
        this.velocity += this.gravity;
        this.velocity *= .9;
        //changes the bird's y coordinates sync with the y velocity
        this.y += this.velocity;

        if (this.y > height)
        {
            this.y = height;
            this.velocity = 0;
        }

        if (this.y < 0)
        {
            this.y = 0;
            this.velocity = 0;
        }
    }


    this.launch = function()
    {
        this.velocity -= this.gravity*20;
    }
}
