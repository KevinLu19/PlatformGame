using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PlatformGame;
public class Game1 : Game
{
	private GraphicsDeviceManager _graphics;
	private SpriteBatch _spritebatch;
	private GameManager _game_manager;

	public Game1()
	{
		_graphics = new GraphicsDeviceManager(this);
		Content.RootDirectory = "Content";
		IsMouseVisible = true;
	}

	protected override void Initialize()
	{
		// TODO: Add your initialization logic here
		// Make window size 1280 x 720.
		_graphics.IsFullScreen = false;
		_graphics.PreferredBackBufferWidth = 1280;
		_graphics.PreferredBackBufferHeight = 720;
		_graphics.ApplyChanges();

		Globals.Content = Content;

		_game_manager = new();
		_game_manager.Init();
		

		base.Initialize();
	}

	protected override void LoadContent()
	{
		_spritebatch = new SpriteBatch(GraphicsDevice);


		// TODO: use this.Content to load your game content here
		Globals.SpriteBatch = _spritebatch;
	}

	protected override void Update(GameTime gameTime)
	{
		if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
			Exit();

		// TODO: Add your update logic here

		Globals.Update(gameTime);
		_game_manager.Update();

		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		GraphicsDevice.Clear(Color.CornflowerBlue);

		// TODO: Add your drawing code here
		_spritebatch.Begin();
		_game_manager.Draw();
		_spritebatch.End();

		base.Draw(gameTime);
	}
}
