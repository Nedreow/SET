using Godot;
using System;

public class Card : Node2D
{
    // Declare member variables here. Examples:
    [Export]
    public int CardSize = 250;

    public int SymbolShape;
    public int SymbolCount;
    public int SymbolColor;
    public int SymbolFill;

    public Card()
    {
        SymbolShape = Convert.ToInt32(GD.Randi() % 3);
        SymbolCount = Convert.ToInt32(GD.Randi() % 3);
        SymbolColor = Convert.ToInt32(GD.Randi() % 3);
        SymbolFill = Convert.ToInt32(GD.Randi() % 3);
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }
    
    public override void _Draw()
    {
        var cardDimensions = new Rect2(0, 0, CardSize, CardSize * 1.4f);
        var cardColor = new Color(1, 1, 0.941176F, 1);
        
        var styleBox = new StyleBoxFlat();
        styleBox.SetCornerRadiusAll(CardSize / 10);
        styleBox.BgColor = cardColor;
        
        DrawStyleBox(styleBox, cardDimensions);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
