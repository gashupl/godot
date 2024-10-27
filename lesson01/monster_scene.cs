using Godot;
using System;

public partial class monster_scene : Sprite2D
{

	int angleInDegrees = 0; 
	int radius = 100; 
	Sprite2D child;
	Label label; 
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		child = this.GetNode<Sprite2D>("MonsterChildSprite");
		label = this.GetNode<Label>("Label");
		//child.Position = new Vector2(100, 100);
		child.GlobalPosition = vector_calculator.CalculatePointOnCircle(30, this.Position, angleInDegrees); 
		label.Text = $"Parent-x: {this.Position.X}, Parent-y: {this.Position.Y} Child-x: {child.Position.X}, Child-y: {child.Position.Y} angleInDegrees: {angleInDegrees}";
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	//Run multiple times (~60) every second
	public override void _Process(double delta)
	{
		label.GlobalPosition = new Vector2(10, 10);
		float SHIFT = 1;
		if (Input.IsKeyPressed(Key.W))
		{		
			this.Position += new Vector2(0, -SHIFT);
			child.GlobalPosition = vector_calculator.CalculatePointOnCircle(radius, this.Position, IncreaseAngle());
		}
		if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, SHIFT);
			child.GlobalPosition = vector_calculator.CalculatePointOnCircle(radius, this.Position, IncreaseAngle()); 
		}
		if (Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-SHIFT, 0);
			child.GlobalPosition = vector_calculator.CalculatePointOnCircle(radius, this.Position, IncreaseAngle()); 
		}
		if (Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(SHIFT, 0);
			child.GlobalPosition = vector_calculator.CalculatePointOnCircle(radius, this.Position, IncreaseAngle()); 
		}

		label.Text = $"Parent-x: {this.Position.X}, Parent-y: {this.Position.Y} Child-x: {child.Position.X}, Child-y: {child.Position.Y} angleInDegrees: {angleInDegrees}";
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
