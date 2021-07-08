using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public Rigidbody alien;
    public float speed = 0.25f;

    float timeoutDuration = 2;
    float timer = 2;

    //public int hits = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if(GameManager.Instance.menu == false)
        //{
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }
        Rigidbody instantiatedProjectile = Instantiate(alien, transform.position, transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

        timer = timeoutDuration;
        //}
       
    }

   /* private void OnCollisionEnter(Collision collision)
    {
        hits--;
        if(hits <= 0)
        {
            Destroy(gameObject);
        }
    }*/
}
