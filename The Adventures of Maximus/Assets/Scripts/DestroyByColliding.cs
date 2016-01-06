using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Xml;

public class DestroyByColliding : MonoBehaviour
{
    public Text text;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        writeToXML();
        SceneManager.LoadScene(4);
    }

    void writeToXML()
    {
        string Path = Application.dataPath + "/Data/Leaderboard.xml";

        XmlDocument doc = new XmlDocument();

        if (!System.IO.File.Exists(Path))
        {
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            XmlComment comment = doc.CreateComment("This is a generated XML File");
            XmlElement Leaderboard = doc.CreateElement("Leaderboard");
            XmlElement survivalTime = doc.CreateElement("SurvivalTime");

            survivalTime.InnerText = text.text;

            doc.AppendChild(declaration);
            doc.AppendChild(comment);
            doc.AppendChild(Leaderboard);

            Leaderboard.AppendChild(Leaderboard);

            Leaderboard.AppendChild(survivalTime);

            //Save document
            doc.Save(Path);
        }

        else //if file already exists
        {
            doc.Load(Path);

            // Get root element
            XmlElement root = doc.DocumentElement;

            XmlElement survivalTime = doc.CreateElement("SurvivalTime");

            //Values to the nodes
            survivalTime.InnerText = text.text;


            //Document Construction
            doc.AppendChild(root);

            // Append root element to word element
            root.AppendChild(survivalTime);

            //Append written values to word as child element

            //Save the document
            doc.Save(Path);
        }
    }
}
