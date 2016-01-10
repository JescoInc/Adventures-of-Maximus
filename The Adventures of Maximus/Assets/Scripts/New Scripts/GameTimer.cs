using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Xml.Serialization;
using System.Xml;

public class GameTimer
{
    private int _seconds;
    private int _minutes;

    private float Score;

    public string ConvertTime()
    {
        Score += Time.deltaTime;
        _minutes = Mathf.FloorToInt(Score / 60f);
        _seconds = Mathf.FloorToInt(Score - _minutes * 60f);
        string formatedTime = string.Format("        {0:0}:{1:00}", _minutes, _seconds);
        return formatedTime;
    }
}
