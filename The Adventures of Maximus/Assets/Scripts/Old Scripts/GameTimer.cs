using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Xml.Serialization;
using System.Xml;

public class GameTimerOld : MonoBehaviour
{
    public Text scoreText;

    public int minutes;
    public int seconds;

    private float Score;

    void Update()
    {
        Score += Time.deltaTime;
        minutes = Mathf.FloorToInt(Score / 60f);
        seconds = Mathf.FloorToInt(Score - minutes * 60f);
        string formatedTime = string.Format("        {0:0}:{1:00}", minutes, seconds);
        scoreText.text = "Survival Time: " + System.Environment.NewLine + formatedTime;
    }
}
