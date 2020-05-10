using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    string axisName = "Horizontal1";
    public float Speed = 15;
    public Text scoreText;
    public GameObject bombPrefab;


    public int Score { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        if(LatestGame.latest == false)
        {
            Lastgame();
        }


    }

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(axisName)*Speed;

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveAxis, 0);
        
    }
    private void FixedUpdate()
    {
        
        string path = Application.persistentDataPath + "/player.data";
        PlayerInfo playerinfo = new PlayerInfo(this);
        SaveLoadManager.Save(path, playerinfo);
    }

    public void MakeScore()
    {
        Score++;
        scoreText.text = Score.ToString();
        if (Score % 5 == 0)
        {
            float levelup = transform.position.y + 1;
            transform.position = new Vector3(0, levelup, 0);
        }
        if (Score % 30 == 0)
        {
            float resetlvl = transform.position.y - 6;
            transform.position = new Vector3(0, resetlvl, 0);
            
        }

    }
    public void Lastgame()
    {
        string path = Application.persistentDataPath + "/player.data";
        PlayerInfo data = SaveLoadManager.Load(path);
        Score = data.Highscore;
        transform.position = new Vector3(0, data.position, 0);
        scoreText.text = Score.ToString();
    }
}
