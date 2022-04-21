using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public int totalStars;

    public SaveData (WinCondition win)
    {
        totalStars = win.totalStars;
    }
}
