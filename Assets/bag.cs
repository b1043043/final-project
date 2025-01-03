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
            Debug.Log($"線索已加入背包：{clueName}");
        }
    }

    public void ShowInventory()
    {
        Debug.Log("玩家背包：");
        foreach (var clue in clues)
        {
            Debug.Log($"- {clue.Key}: {clue.Value}");
        }
    }
}
