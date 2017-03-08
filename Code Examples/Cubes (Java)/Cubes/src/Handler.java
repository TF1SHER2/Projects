import java.awt.Graphics;
import java.util.LinkedList;

public class Handler
{
	public static LinkedList<GameObject> object = new LinkedList<GameObject>();

	public void tick()
	{
		for (int i = 0; i < object.size(); i++)
		{
			GameObject tempObject = object.get(i);

			if ((tempObject.getId() == ID.Enemy) && (tempObject.getY() > Driver.HEIGHT))
			{
				object.remove(i);
			} 
			else
			{
				tempObject.tick();
			}
		}

	}

	public void render(Graphics g)
	{
		for (int i = 0; i < object.size(); i++)
		{
			GameObject tempObject = object.get(i);

			tempObject.render(g);
		}
	}
}