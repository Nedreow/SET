using System.Collections.Generic;
using System.Diagnostics;
using Godot;

namespace SET
{
    public class Config
    {
        private static Dictionary<int, string> _shapes = new Dictionary<int, string>()
        {
            { 1, "Oval" },
            { 2, "Rectangle" },
            { 3, "Wave" },
        };

        private static Dictionary<int, string> _fills = new Dictionary<int, string>()
        {
            { 1, "Outline" },
            { 2, "Barred" },
            { 3, "Solid" },
        };

        public static Dictionary<int, Dictionary<int, Texture>> Textures =
            new Dictionary<int, Dictionary<int, Texture>>()
            {
                {
                    1, new Dictionary<int, Texture>()
                    {
                        { 1, ResourceLoader.Load<Texture>(_resourcePath(1, 1)) },
                        { 2, ResourceLoader.Load<Texture>(_resourcePath(1, 2)) },
                        { 3, ResourceLoader.Load<Texture>(_resourcePath(1, 3)) }
                    }
                },{
                    2, new Dictionary<int, Texture>()
                    {
                        { 1, ResourceLoader.Load<Texture>(_resourcePath(2, 1)) },
                        { 2, ResourceLoader.Load<Texture>(_resourcePath(2, 2)) },
                        { 3, ResourceLoader.Load<Texture>(_resourcePath(2, 3)) }
                    }
                },{
                    3, new Dictionary<int, Texture>()
                    {
                        { 1, ResourceLoader.Load<Texture>(_resourcePath(3, 1)) },
                        { 2, ResourceLoader.Load<Texture>(_resourcePath(3, 2)) },
                        { 3, ResourceLoader.Load<Texture>(_resourcePath(3, 3)) }
                    }
                }
            };

        public static Dictionary<int, Color> Colors = new Dictionary<int, Color>()
        {
            { 1, Color.Color8(197, 12, 12) },
            { 2, Color.Color8(0, 127, 0) },
            { 3, Color.Color8(73, 0, 129) },
        };
        
        private static string _resourcePath(int shape, int fill) 
        {
            return $"Resources/{_shapes[shape]} {_fills[fill]}.png";
        }
    };

        
}