using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public Rigidbody bullet;
    public float speed = 20;

    public int hits = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //https://forum.unity.com/threads/gun-shooting-script-c.222057/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        hits--;
        if(hits <= 0)
        {
            //print("bruhhh");
            Destroy(gameObject);
        }
        
    }
}
