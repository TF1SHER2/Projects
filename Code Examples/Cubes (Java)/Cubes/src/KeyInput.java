import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

import javax.swing.JOptionPane;

public class KeyInput extends KeyAdapter {
	

	
	
	public void keyPressed(KeyEvent e)
	{
		int key = e.getKeyCode();
		
		for (int i = 0; i< Handler.object.size(); i++)
		{
			GameObject tempObject = Handler.object.get(i);
			
			if (tempObject.getId() == ID.Player)
			{
				//if the key the player presses is left arrow, or A, move left
				if (key == KeyEvent.VK_LEFT || key == KeyEvent.VK_A)
				{
					tempObject.setX(tempObject.getX()-15);
					
				}
				//if the key the player presses is right arrow, or D, move right
				if (key == KeyEvent.VK_RIGHT || key == KeyEvent.VK_D)
				{
					tempObject.setX(tempObject.getX()+15);
				}
				
				if (key == KeyEvent.VK_ESCAPE)
				{
					//Somehow pause this monstrosity
				}
			}
		}
	}
	
	public void keyReleased(KeyEvent e)
	{
		int key = e.getKeyCode();
		for (int i = 0; i< Handler.object.size(); i++)
		{
			GameObject tempObject = Handler.object.get(i);
			
			if (tempObject.getId() == ID.Player)
			{
				//if the key the player releases the left arrow, or A, stop moving
				if (key == KeyEvent.VK_LEFT || key == KeyEvent.VK_A)
				{
					tempObject.setX(tempObject.getX());
				}
				//if the key the player releases the right arrow, or D, stop moving
				if (key == KeyEvent.VK_RIGHT || key == KeyEvent.VK_D)
				{
					tempObject.setX(tempObject.getX());
				}
				if (key == KeyEvent.VK_ESCAPE)
				{
					//reset the movement speed
				}
			}
		}
	}
}
