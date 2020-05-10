using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInfo 
{
    public int Highscore;
    public float position;

    public PlayerInfo (player player)
    {
        Highscore = player.Score;
        position = player.transform.position.y;
    }
}
