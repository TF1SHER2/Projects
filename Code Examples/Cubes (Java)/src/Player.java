import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

import javax.swing.JOptionPane;

public class Player extends GameObject {

	static Handler handler;
	private int score = 0;
	
	public Player(int x, int y, ID id) {
		super(x, y, id);
		xSpeed = 0;

	}
	
	public void tick()
	{
		y += ySpeed;
		x += xSpeed;
		x = Driver.clamp(x, 0, Driver.WIDTH-35);
		collision();
	}
	
	public void collision()
	{
		for (int i=0; i < Handler.object.size(); i++)
		{
			GameObject tempObject = Handler.object.get(i);
			
			if (tempObject.getId() == ID.Enemy)
			{
				if (getBounds().intersects(tempObject.getBounds()))
				{
					//Driver.paused = true;
					Object[] button = {  "Play Again", "Exit" };
					int playAgain = JOptionPane.showOptionDialog(null,
							"You Lost!",
							"", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, button, button[0]);
					if (playAgain == JOptionPane.YES_OPTION)
					{
						resetScreen();
					}
					else
					{
						System.exit(0);
					}
				}
			}
		}
	}
	
	public static void resetScreen()
	{
		Handler.object.clear();
		Player player = new Player(450, 575, ID.Player);
		Handler.object.add(player);
		//Driver.paused = false;
	}
	
	public void render (Graphics g)
	{
		g.setColor(Color.red);
		g.fillRect(x, y, 60, 60);
	}

	
	public Rectangle getBounds()
	{
		return new Rectangle (x, y, 60, 60);
	}
	
	
	public int getScore(){
		return score;
	}
	
	public void addToScore(int add){
		score += add;
	}
	
}
