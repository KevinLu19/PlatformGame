namespace PlatformGame;

public class GameManager
{
	private King _king_obj;
	private Map _map_obj;

	public void Init()
	{
		_king_obj = new();
		_map_obj = new();
	}

	public void Update()
	{
		Input.Update();
		_king_obj.Update();
	}

	public void Draw()
	{
		_map_obj.Draw();
		_king_obj.Draw();
		
	}

}