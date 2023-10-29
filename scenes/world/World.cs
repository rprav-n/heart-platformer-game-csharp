using Godot;
using System;

public partial class World : Node2D
{
	
	private CollisionPolygon2D collisionPolygon2D;
	private Polygon2D polygon2D;
	
	public override void _Ready()
	{
		collisionPolygon2D = GetNode<CollisionPolygon2D>("StaticBody2D/CollisionPolygon2D");
		polygon2D = GetNode<Polygon2D>("StaticBody2D/CollisionPolygon2D/Polygon2D");
		
		polygon2D.Polygon = collisionPolygon2D.Polygon;
	}
}
