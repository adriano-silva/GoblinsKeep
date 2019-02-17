using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class AdventureGame : MonoBehaviour
{
	
	private const string LANGUAGE_STATE_NAME = "Language"; // Name of the language selection state
	private const string ENGLISH = "en";
	private const string FRENCH = "fr";
	
	[SerializeField] Text textComponent; // Text component displaying the story
	[SerializeField] private State startingState; // Starting state of the game

	[SerializeField] private string language = ENGLISH; // Default language
	
	private State state;
	
	// Sets the first state, and displays the english text on it
	void Start ()
	{
		state = startingState;
		textComponent.text = state.GetStateStoryEN();

	}
	
	// Update is called once per frame
	void Update ()
	{
		ManageState();
	}

	
	// Manage the next states according to language and number pressed by user
	private void ManageState()
	{
		var nextStates = state.GetNextStates();
		if (Input.GetKeyDown(KeyCode.Alpha1) && nextStates.Length>=1)
		{
			state = nextStates[0];
		}else if (Input.GetKeyDown(KeyCode.Alpha2) && nextStates.Length>=2)
		{
			state = nextStates[1];
		}else if (Input.GetKeyDown(KeyCode.Alpha3) && nextStates.Length>=3)
		{
			state = nextStates[2];
		}else if (Input.GetKeyDown(KeyCode.Alpha4) && nextStates.Length>=4)
		{
			state = nextStates[3];
		}else if (Input.GetKeyDown(KeyCode.Q))
		{
			Application.Quit();
		}else if (Input.GetKeyDown(KeyCode.E) && state.name.Equals(LANGUAGE_STATE_NAME))
		{
			language = ENGLISH;
			state = nextStates[0];
		}else if (Input.GetKeyDown(KeyCode.F) && state.name.Equals(LANGUAGE_STATE_NAME))
		{
			language = FRENCH;
			state = nextStates[0];
		}

		// Gets text according to selected language
		switch (language)
		{
			case ENGLISH:
				textComponent.text = state.GetStateStoryEN();
				break;
			case FRENCH:
				textComponent.text = state.GetStateStoryFR();
				break;
		}
		
	}
}
 