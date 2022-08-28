using Godot;
using System;
using SET;

public class Main : Node
{
    // Declare member variables here. Examples:
    public Deck Deck;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Randomize();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
