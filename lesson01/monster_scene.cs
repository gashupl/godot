using Godot;
using System;

public partial class monster_scene : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var child = this.GetNode<Godot.Sprite2D>("MonsterChildSprite"); 
		//child.Position = new Vector2(100, 100);
		child.Position = CalculatePointOnCircle(10, this.Position, 0); 
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	//Run multiple times (~60) every second
	public override void _Process(double delta)
	{
		float SHIFT = 5;
		if (Input.IsKeyPressed(Key.W))
		{		
			this.Position += new Vector2(0, -SHIFT);
		}
		if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, SHIFT);
		}
		if (Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-SHIFT, 0);
		}
		if (Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(SHIFT, 0);
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
}
