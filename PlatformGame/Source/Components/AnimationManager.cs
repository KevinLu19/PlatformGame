using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace PlatformGame;
public class AnimationManager
{
    private readonly Dictionary<object, Animation> _anims = new();
    private object _lastkey;

    public void AddAnimation(object key, Animation animation)
    {
        _anims.Add(key, animation);
        _lastkey ??= key;
    }

    public void Update(object key)
    {
        if (_anims.TryGetValue(key, out Animation value))
        {
            value.Start();
            _anims[key].Update();
            _lastkey = key;
        }
        else
        {
            _anims[_lastkey].Stop();
            _anims[_lastkey].Reset();
        }
    }

    public void Draw(Vector2 position)
    {
        _anims[_lastkey].Draw(position);
    }
}