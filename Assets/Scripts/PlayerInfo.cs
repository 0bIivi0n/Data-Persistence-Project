using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo playerInfo;
    public string playerName;
    public int score;
    

    private void Awake()
    {
        if(playerInfo != null)
        {
            Destroy(gameObject);
            return;
        }

        playerInfo = this;
        DontDestroyOnLoad(gameObject);
    }
}
