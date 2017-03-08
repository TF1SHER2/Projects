import java.awt.Canvas;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferStrategy;
import java.util.Random;


public class Driver extends Canvas implements Runnable
{
	private static final long serialVersionUID = -7400898405578270179L;

	public static final int WIDTH = 1000, HEIGHT = WIDTH / 3 * 2;
	private Thread thread;
	private boolean running = false;
	private Handler handler;
	private Random r;
	public static boolean paused = false;
	public static Player p;

	public Driver()
	{
		handler = new Handler();
		this.addKeyListener(new KeyInput());

		new Window(WIDTH, HEIGHT, "Road to Jolly JackPot Land!", this);
		r = new Random();
		Player p = new Player(450, 575, ID.Player);
		Handler.object.add(p);
		//JOptionPane.showMessageDialog(this, "The road to jolly jackpot land is filled with pot holes! \nHow long can you last?");
		
		// This will generate a row of bricks (or enemies) every 3 seconds
		while (running)
		{
			
			for (int i = 0; i < 2; i++)
			{
				Handler.object.add(new Brick(r.nextInt(WIDTH), -40, ID.Enemy)); 
			}
			try
			{
				//System.out.println(p.getScore());
				Thread.sleep(500);
			}
			catch (InterruptedException ex)
			{
				Thread.currentThread().interrupt();
			}
		}
		
	}

	public synchronized void start()
	{
		running = true;
		thread = new Thread(this);
		thread.start();
	}

	public synchronized void stop()
	{
		try
		{
			thread.join();
			running = false;
		}
		catch (Exception e)
		{
			e.printStackTrace();
		}
	}

	public void run()
	{
		long lastTime = System.nanoTime();
		double amountOfTicks = 60.0;
		double ns = 1000000000 / amountOfTicks;
		double delta = 0;
		long timer = System.currentTimeMillis();
		int frames = 0;
		while (running)
		{
			long now = System.nanoTime();
			delta += (now - lastTime) / ns;
			lastTime = now;
			while (delta >= 1)
			{
				tick();
				delta--;
			}
			if (running)
			{
				render();
			}
			frames++;

			if (System.currentTimeMillis() - timer > 1000)
			{
				timer += 1000;
				System.out.println("Frames Per Second: " + frames);
				frames = 0;
			}
		}
		stop();
	}

	private void tick()
	{
		handler.tick();
	}

	private void render()
	{
		BufferStrategy bs = this.getBufferStrategy();
		if (bs == null)
		{
			this.createBufferStrategy(3);
			return;
		}

		Graphics g = bs.getDrawGraphics();
		g.setColor(Color.darkGray);
		g.fillRect(0, 0, WIDTH, HEIGHT);

		handler.render(g);

		g.dispose();
		bs.show();
	}

	public static int clamp(int var, int min, int max)
	{
		if (var >= max)
		{
			return var = max;
		}
		else if (var <= min)
		{
			return var = min;
		}
		else
		{
			return var;
		}
	}

	public static void main(String[] args)
	{
		new Driver();
	}
}
