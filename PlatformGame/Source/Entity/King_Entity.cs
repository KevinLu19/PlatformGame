using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PlatformGame;

public class King : ISprite
{
	private Vector2 _position = new(100, 100);
	private readonly float _speed = 200f;
	private readonly AnimationManager _anim_manager = new();

	public King()
	{
		var king_texture = Globals.Content.Load<Texture2D>("Attack");

		// This allows the king sprite to move in 8 different directions. 
		/*
			Vector2(x,y) -> This is the direction coordination
		 */
		_anim_manager.AddAnimation(new Vector2(0, 1), new(king_texture, 3, 1, 0.1f));
		_anim_manager.AddAnimation(new Vector2(-1,0), new(king_texture, 3, 1, 0.1f));
		_anim_manager.AddAnimation(new Vector2(1, 0), new(king_texture, 3, 1, 0.1f));
		_anim_manager.AddAnimation(new Vector2(0, -1), new(king_texture, 3, 1, 0.1f));
		_anim_manager.AddAnimation(new Vector2(-1, 1), new(king_texture, 3, 1, 0.1f));
		_anim_manager.AddAnimation(new Vector2(-1, -1), new(king_texture, 3, 1, 0.1f));
		_anim_manager.AddAnimation(new Vector2(1, 1), new(king_texture, 3, 1, 0.1f));
		_anim_manager.AddAnimation(new Vector2(1, -1), new(king_texture, 3, 1, 0.1f));
	}

	public void Update()
	{
		if (Input.Moving)
		{
			_position += Vector2.Normalize(Input.Direction) * _speed * Globals.TotalSeconds;
		}
		_anim_manager.Update(Input.Direction);
	}

	public void Draw()
	{
		_anim_manager.Draw(_position);
	}
}