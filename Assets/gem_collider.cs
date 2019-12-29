using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem_collider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameController;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<Animator>().SetTrigger("gem_collect");
        GetComponent<AudioSource>().Play();

        gameController.GetComponent<score_mgmt>().addScore();

        Debug.Log("Coin collected");    
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       //
    }
     
}
