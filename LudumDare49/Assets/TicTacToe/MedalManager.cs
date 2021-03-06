using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public static class MedalManager
{
    private static bool[] CorrectNails = new bool[8];

    private static GameObject currentMedal = null;

    public static void SetCurrentMedal(GameObject Medal)
    {
        currentMedal = Medal;
    }

    public static GameObject GetCurrentMedal()
    {
        return currentMedal;
    }

    public static void AddCorrectNail(int index)
    {
        CorrectNails[index] = true;
        checkFinished();
    }

    public static void RemoveCorrectNail(int index)
    {
        CorrectNails[index] = false;
    }

    private static void checkFinished()
    {
        for (int x = 0; x < CorrectNails.Length; x++)
        {
            if (CorrectNails[x] == false)
            {
                return;
            }
        }

        //GameObject.FindObjectOfType<InMemoryVariableStorage>().SetValue("finished_Medal_Puzzle", true);
        //GameObject.Destroy(GameObject.Find("MedalNew").GetComponent<StartDialogueNode>());
        GameObject.FindObjectOfType<DialogueRunner>().StartDialogue("MedalGameFinish");
    }
}
