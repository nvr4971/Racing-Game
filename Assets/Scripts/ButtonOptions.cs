using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
	public void QuickPlay()
	{
		GlobalCar.CarType = Random.Range(1, 2);
		ModeSelect.RaceMode = 0;
		SceneManager.LoadScene(Random.Range(2, 3));
	}

	public void CustomGame()
	{
		SceneManager.LoadScene(1);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}

	//Below here are track selection buttons

	public void Track01()
	{
		SceneManager.LoadScene(2);
	}

	public void Track02()
	{
		SceneManager.LoadScene(3);
	}

	public void Credits()
	{
		SceneManager.LoadScene(4);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
