using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField]
    public float XSpeed = 5;
    [SerializeField]
    public float YSpeed = 5;


    Material material;
    Vector2 offset;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(XSpeed, YSpeed);
    }

    void Update()
    {

        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
