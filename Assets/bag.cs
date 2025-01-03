using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Dictionary<string, string> clues = new Dictionary<string, string>();

    public void AddClue(string clueName, string clueDescription)
    {
        if (!clues.ContainsKey(clueName))
        {
            clues.Add(clueName, clueDescription);
            Debug.Log($"�u���w�[�J�I�]�G{clueName}");
        }
    }

    public void ShowInventory()
    {
        Debug.Log("���a�I�]�G");
        foreach (var clue in clues)
        {
            Debug.Log($"- {clue.Key}: {clue.Value}");
        }
    }
}
