using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien : MonoBehaviour
{

    public int hits = 1;
    public int skore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        hits--;
        if(hits <= 0)
        {
            GameManager.Instance.Score += 10;
            Destroy(gameObject);
            score.Scores += 10;
            //score.scores += 100;
        }


       /* if(collision.transform.name == "bullet")
        {
            print("bruhhh");
            //score.Scores += 100;
        }*/
    }

    /*public void OnGUI()
    {
        GUI.Box(new Rect(-2, 3.25f, 50, 50), skore.ToString());
    }*/

}
