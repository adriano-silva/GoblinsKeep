using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
   
   [TextArea(10,14)] [SerializeField] private string storyTextEN; // State text in English
   [TextArea(10,14)] [SerializeField] private string storyTextFR; // State text in French
   
   [SerializeField] State[] nextStates;

   // Returns the English state text
   public string GetStateStoryEN()
   {
      return storyTextEN;
   }
   
   // Returns the French state text
   public string GetStateStoryFR()
   {
      return storyTextFR;
   }

   // Returns next states
   public State[] GetNextStates()
   {
      return nextStates;
   }
}
