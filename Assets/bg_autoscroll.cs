using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_autoscroll : MonoBehaviour
{
    //public GameObject tile_child;

    public GameObject tile;
    public GameObject background;
    public GameObject middleground;

    public float speed = -3;

    public GameObject crate;

    private GameObject tile2;
    private GameObject background2;
    private GameObject middleground2;

    private GameObject[] objects;

    private System.Random rng = new System.Random();

    private void getRandomObstacle(GameObject obj)
    {        
        if (obj.name.Contains("Tiles"))
        {
            int r = rng.Next(3);
            //r = 2;    // coins
            Debug.Log("Obstacle # " + r);

            obj.transform.Find("crate").gameObject.SetActive(r == 0 ? true : false);
            obj.transform.Find("rock").gameObject.SetActive(r == 1 ? true : false);
            obj.transform.Find("platform").gameObject.SetActive(r == 2 ? true : false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tile2 = GameObject.Instantiate(tile, new Vector3(29.5f, 0, 0), Quaternion.identity);
            getRandomObstacle(tile2);
        background2 = GameObject.Instantiate(background, new Vector3(29.4f, 0, 0), Quaternion.identity);
        middleground2 = GameObject.Instantiate(middleground, new Vector3(29.4f, 0, 0), Quaternion.identity);

        objects = new GameObject[]{ tile, tile2, background, background2, middleground, middleground2 };
    }

    // Update is called once per frame
    void Update()
    {
        System.Array.ForEach( objects,
            obj => {
                if ((obj.transform.position.x > -30) & (obj.transform.position.x < -29))
                {
                    obj.transform.position = new Vector3(29.4f, 0, 0);
                    getRandomObstacle(obj);
                }
            });        

        tile.transform.Translate(speed * Time.deltaTime, 0, 0);
        tile2.transform.Translate(speed * Time.deltaTime, 0, 0);

        background.transform.Translate((speed+2) * Time.deltaTime, 0, 0);
        background2.transform.Translate((speed+2) * Time.deltaTime, 0, 0);

        middleground.transform.Translate((speed + 1) * Time.deltaTime, 0, 0);
        middleground2.transform.Translate((speed + 1) * Time.deltaTime, 0, 0);
    }
}
