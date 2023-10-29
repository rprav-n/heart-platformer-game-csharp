using Godot;
using System;

public partial class player : CharacterBody2D
{
	
	const int SPEED = 100;
	const int JUMP_SPEED = -300;
	
	private int GRAVITY;

	public override void _Ready()
	{
		base._Ready();
		
		GRAVITY = (int)ProjectSettings.GetSetting("physics/2d/default_gravity");

	}

	public override void _PhysicsProcess(double delta)
	{
		
		var playerVelocity = Velocity;
		
		if (!IsOnFloor()) 
		{
			playerVelocity.Y += GRAVITY * (float)delta;
		}
		
		float inputAxis = Input.GetAxis("move_left", "move_right");
		
		if (inputAxis != 0) 
		{
			playerVelocity.X = inputAxis * SPEED;
		} else 
		{
			playerVelocity.X = Mathf.MoveToward(Velocity.X, 0, SPEED);
		}
		
		
		Velocity = playerVelocity;
		MoveAndSlide();
		
	}

}
