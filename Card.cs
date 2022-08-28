using Godot;
using System;
using SET;

public class Card : Node2D
{
    private int _cardSize = 250;

    [Export]
    public float CardScale = 1f;

    private readonly CardProperties _cardProperties;

    public int SymbolShape => _cardProperties.SymbolShape;
    public int SymbolCount => _cardProperties.SymbolCount;
    public int SymbolColor => _cardProperties.SymbolColor;
    public int SymbolFill => _cardProperties.SymbolFill;

    public Card(CardProperties card)
    {
        _cardProperties = card;
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
        var cardDimensions = new Rect2(0, 0, _cardSize * CardScale, _cardSize * 1.4f * CardScale);
        var cardColor = new Color(1, 1, 0.941176F, 1);
        
        var styleBox = new StyleBoxFlat();
        styleBox.SetCornerRadiusAll(_cardSize / 10);
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
        sprite.Scale = new Vector2(0.20f * CardScale, 0.20f * CardScale);
        sprite.Offset = new Vector2(_cardSize * 2.5f, _cardSize * (1.6f + startingOffset + 1.9f * location));
        sprite.Modulate = Config.Colors[SymbolColor];
        
        AddChild(sprite);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
