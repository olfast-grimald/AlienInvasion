using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shoot : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //assigned Fire1 to spacebar, instantiated projectile IS the projectile assigned in inspector (bullet prefab), at the spawn point => as a rigid bod
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody InstantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            InstantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
    }
}
