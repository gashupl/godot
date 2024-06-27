using Godot;
using System;

public partial class monster_scene : Sprite2D
{

	int angleInDegrees = 0; 
	int radius = 30; 
	Godot.Sprite2D child; 
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		child = this.GetNode<Godot.Sprite2D>("MonsterChildSprite"); 
		//child.Position = new Vector2(100, 100);
		child.Position = CalculatePointOnCircle(30, this.Position, angleInDegrees); 
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	//Run multiple times (~60) every second
	public override void _Process(double delta)
	{
		float SHIFT = 5;
		if (Input.IsKeyPressed(Key.W))
		{		
			this.Position += new Vector2(0, -SHIFT);
			child.Position = CalculatePointOnCircle(radius, this.Position, IncreaseAngle()); 
		}
		if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, SHIFT);
			child.Position = CalculatePointOnCircle(radius, this.Position, IncreaseAngle()); 
		}
		if (Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-SHIFT, 0);
			child.Position = CalculatePointOnCircle(radius, this.Position, IncreaseAngle()); 
		}
		if (Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(SHIFT, 0);
			child.Position = CalculatePointOnCircle(radius, this.Position, IncreaseAngle()); 
		}
	}
	public static Vector2 CalculatePointOnCircle(float radius, Vector2 center, float angleInDegrees)
	{
		// Convert angle in degrees to radians
		double angleInRadians = angleInDegrees * (Math.PI / 180);

		float x = center.X + (float)(radius * Math.Cos(angleInRadians));
		float y = center.Y + (float)(radius * Math.Sin(angleInRadians));

		return new Vector2(x, y);
	}

	public int IncreaseAngle()
	{
		angleInDegrees += 1;
		if(angleInDegrees >= 360)
		{
			angleInDegrees = 0;
		}
		return angleInDegrees;
	}
}
