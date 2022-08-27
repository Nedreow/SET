using Godot;
using System;
using SET;

public class Card : Node2D
{
    public int CardSize = 250;

    [Export] public float cardScale = 1f;

    public readonly int SymbolShape;
    public readonly int SymbolCount;
    public readonly int SymbolColor;
    public readonly int SymbolFill;

    public Card()
    {
        SymbolShape = 2;
        SymbolCount = 2;
        SymbolColor = 3;
        SymbolFill = 3;
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();

        for (int i = 0; i < SymbolCount; i++)
        {
            addSymbol(i);
        }
    }
    
    public override void _Draw()
    {
        var cardDimensions = new Rect2(0, 0, CardSize * cardScale, CardSize * 1.4f * cardScale);
        var cardColor = new Color(1, 1, 0.941176F, 1);
        
        var styleBox = new StyleBoxFlat();
        styleBox.SetCornerRadiusAll(CardSize / 10);
        styleBox.BgColor = cardColor;
        
        DrawStyleBox(styleBox, cardDimensions);
    }

    private void addSymbol(int location)
    {
        float startingOffset = 0f;
        switch (SymbolCount)
        {
            case 1:
                startingOffset = 1.9f;
                break;
            case 2:
                startingOffset = 0.95f;
                break;
        }
        
        var sprite = new Sprite();
        sprite.Texture = Config.Textures[SymbolShape][SymbolFill];
        sprite.Scale = new Vector2(0.20f * cardScale, 0.20f * cardScale);
        sprite.Offset = new Vector2(CardSize * 2.5f, CardSize * (1.6f + startingOffset + 1.9f * location));
        sprite.Modulate = Config.Colors[SymbolColor];
        
        AddChild(sprite);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
