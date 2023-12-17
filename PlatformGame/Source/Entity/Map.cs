using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PlatformGame;


public class Map
{
    private readonly Texture2D _texture;
    public Map()
    {
        var map = Globals.Content.Load<Texture2D>("Map");

        _texture = map;
    }

    public void Draw()
    {
        Globals.SpriteBatch.Draw(_texture, new Vector2(0,0), Color.White);
    }
}