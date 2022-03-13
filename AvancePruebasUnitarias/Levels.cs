using System;

public class Levels
{
	public Enemy enemy;
	public Player player;
	public Levels()
	{

	}

	public void GenerateEnemy()
    {
		enemy = new Enemy();
    }

	public void GeneratePlayer()
    {
		player = new Player();
    }
}
