using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Text text;

    private GameTimer time = new GameTimer();
    private NewLeaderBoard dataSource = new NewLeaderBoard();
    private GameStartEnd gameControl = new GameStartEnd();

    void Update()
    {
       text.text = time.ConvertTime();
    }
}
