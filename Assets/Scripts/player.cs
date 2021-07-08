using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ASTEROID MAY 1
public class player : MonoBehaviour
{

    Rigidbody playerrb;
    float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        playerrb.velocity = new Vector3(horizontalInput * 7, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //so that game doesn't enter GAME OVER state when player collides with borders uwu
        if(collision.transform.gameObject.name != "Cube" && collision.transform.gameObject.name != "Cube (1)")
        {
            GameManager.Instance.switchState(GameManager.State.GAMEOVER);
            Destroy(gameObject);
        }
        /*
        else if (collision.transform.gameObject.name != "Cube (1)")
        {
            GameManager.Instance.switchState(GameManager.State.GAMEOVER);
            Destroy(gameObject);
        }*/
    }
}
