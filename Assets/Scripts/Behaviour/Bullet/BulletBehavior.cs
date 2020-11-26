using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private Rigidbody2D rgdb;
    protected Transform effects;
    
    void Start()
    {
        rgdb = GetComponent<Rigidbody2D>();
        rgdb.AddRelativeForce(Vector2.up * 500);
        Destroy(gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
