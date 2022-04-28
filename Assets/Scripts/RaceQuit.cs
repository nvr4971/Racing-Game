using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceQuit : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(0);
		}
	}
}
