using System;
using Godot;

public partial class Player : CharacterBody3D
{
    [Export]
    public int Speed { get; set;} = 14;
	[Export] 
	public int FallAcceleration {get; set;} = 75; 

	private Vector3 _targetVelocity = Vector3.Zero;

	public override void _PhysicsProcess(double delta)
	{
		var direction = Vector3.Zero;

		if (Input.IsActionPressed("move_right"))
		{
			direction.X += 1.0f;
		}
		if (Input.IsActionPressed("move_left"))
		{
			direction.X -= 1.0f;
		}

		if (Input.IsActionPressed("move_back"))
		{
			
		}
		
	}
}