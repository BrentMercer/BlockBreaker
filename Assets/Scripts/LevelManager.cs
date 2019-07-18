using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		Debug.Log("Level load requested for: " + name);
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}

	public void QuitRequest (string name) {
		Debug.Log("I wanna quit");
		Application.Quit();
	}

	public void MainMenu (string name) {
		Debug.Log("Main menu");
		Application.LoadLevel(name);
	}

	public void LoadNextLevel()	{
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void BrickDestroyed() {
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
}