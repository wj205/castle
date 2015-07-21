using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject winText;
	public GameObject loseText;

	void Start()
	{
		winText.SetActive (false);
		loseText.SetActive (false);
	}

	void Update()
	{
		if(Input.GetKeyDown (KeyCode.Space))
		{
			WinGame ();
		}
	}

	public void WinGame()
	{
		winText.SetActive (true);
	}

	public void LoseGame()
	{
		loseText.SetActive (true);
	}
}
