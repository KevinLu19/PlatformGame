namespace PlatformGame;

public class GameManager
{
	private King _king_obj;

	public void Init()
	{
		_king_obj = new();
	}

	public void Update()
	{
		Input.Update();
		_king_obj.Update();
	}

	public void Draw()
	{
		_king_obj.Draw();
	}

}