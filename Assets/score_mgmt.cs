using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_mgmt : MonoBehaviour
{
    public GameObject uiScore;
    public GameObject player;

    private int score = 0;

    public void addScore()
    {
        uiScore.GetComponentInChildren<TextMesh>().text = (++score).ToString();

        GetComponentInParent<bg_autoscroll>().speed = GetComponentInParent<bg_autoscroll>().speed - 0.5f;
        player.GetComponent<Animator>().speed = player.GetComponent<Animator>().speed + 0.05f;
        Debug.Log("player speed is now: " + player.GetComponent<Animator>().speed );
    }

    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
