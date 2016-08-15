using UnityEngine;
using System.Collections;

public class ResponseSceneManager : MonoBehaviour {

	public GameObject peaceButton;
	public GameObject peaceText;
	public GameObject deathText;


	// Use this for initialization
	void Start () {

		//Sets all game objects inactive
		peaceButton.SetActive (false);
		peaceText.SetActive (false);
		deathText.SetActive (false);

		int randomNumber = Random.Range (1, 3); //Between 1 and 3 b/c 3 is exclusive but 1 is inclusive
		Debug.Log ("The random number is:" + randomNumber);

		if (randomNumber == 1) {
			// This code is to run the peaceful scenario
			peaceButton.SetActive (true);
			peaceText.SetActive (true);
		}

		if (randomNumber == 2) {
			// This code is to run the death scenario
			deathText.SetActive (true);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
