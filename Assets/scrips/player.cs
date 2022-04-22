using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody rd;

    public int force = 5;

    // Start is called before the first frame update
    void Start()
    {
        rd =GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v)*force);
    }
    void OnCollisionEnter(Collision collision)
    {
        //collision.collider;
       string name= collision.collider.name;
        print(name);
        if(collision.collider.tag=="Pick up")
        {
            Destroy(collision.collider.gameObject);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag=="Pick up")
        {
            Destroy(collider.gameObject);
        }
    }
}
