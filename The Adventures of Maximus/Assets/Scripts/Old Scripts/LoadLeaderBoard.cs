using UnityEngine;
using System.Collections;
using System.Xml;
using UnityEngine.UI;

public class LoadLeaderBoardOld : MonoBehaviour
{
    public Text text;
    public GameObject content;

    void Start()
    {
        string Path = Application.dataPath + "/Data/Leaderboard.xml";

        XmlDocument doc = new XmlDocument();

        doc.Load(Path);

        XmlNodeList elemList = doc.GetElementsByTagName("SurvivalTime");
        for (int i = 0; i < elemList.Count; i++)
        {
            text = Instantiate<Text>(text);
            text.transform.SetParent(content.transform, false);
            text.text = elemList[i].InnerXml;
        }
    }
}
