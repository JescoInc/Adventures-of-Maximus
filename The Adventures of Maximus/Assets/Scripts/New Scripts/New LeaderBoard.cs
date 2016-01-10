using UnityEngine;
using System.Collections;

public class NewLeaderBoard
{
    public NewLeaderBoard()
    {

    }

    public void SaveData(string survivalTime)
    {      
        JsonUtility.ToJson(survivalTime);
    }

    public void LoadData()
    {

    }
}
