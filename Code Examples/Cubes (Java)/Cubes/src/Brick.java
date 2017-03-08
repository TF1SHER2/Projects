import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

public class Brick extends GameObject
{
	

	public Brick(int x, int y, ID id) {
		super(x, y, id);
		ySpeed = 3;
		
	}
	
	public void tick()
	{
		y += ySpeed;
		x = Driver.clamp(x, 0, Driver.WIDTH-50);
	}
	
	public void render (Graphics g)
	{
		g.setColor(Color.black);
		g.fillRect(x, y, 50, 50);
	}

	public Rectangle getBounds()
	{
		return new Rectangle (x, y, 50, 50);
	}
	
}
