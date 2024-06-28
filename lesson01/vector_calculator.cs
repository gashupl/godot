using Godot;
using System;

public partial class vector_calculator : Sprite2D
{

	public static Vector2 CalculatePointOnCircle(float radius, Vector2 center, float angleInDegrees)
	{
		// Convert angle in degrees to radians
		double angleInRadians = angleInDegrees * (Math.PI / 180);

		float x = center.X + (float)(radius * Math.Cos(angleInRadians));
		float y = center.Y + (float)(radius * Math.Sin(angleInRadians));

       // label.Text = $"Parent-x: {center.X}, Parent-y: {center.Y} Child-x: {x}, Child-y: {y} angleInDegrees: {angleInDegrees}";

        return new Vector2(x, y);
	}

}
