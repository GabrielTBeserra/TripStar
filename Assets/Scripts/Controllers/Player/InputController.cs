﻿using Assets.Scripts.Interfaces.Player;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private IRigidBody rigidBody;
    private ISpeed speed;
    private IShoot shoot;
    private Camera cam;

    public static int gameEnemies = 0;
    public static int gameAsteroids = 0;
    private float lastSpawnedAmmoTime;
    private float timeAmmoCounter;
    private double spawnAmmoInterval = 0.2;


    private void Start()
    {
        rigidBody = GameObject.FindGameObjectWithTag("Player").GetComponent<IRigidBody>();
        speed = GameObject.FindGameObjectWithTag("Player").GetComponent<ISpeed>();
        shoot = GameObject.FindGameObjectWithTag("Player").GetComponent<IShoot>();
        cam = Camera.main;
    }

    private void Update()
    {
        timeAmmoCounter += Time.deltaTime;

        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            transform.position = (Vector2)cam.ScreenToWorldPoint(touch.position);
        }
        else
        {
            float h = speed.GetSpeed().rotateSpeed * Input.GetAxisRaw("Horizontal");
            float v = speed.GetSpeed().rotateSpeed * Input.GetAxisRaw("Vertical");

            rigidBody.GetRigidBody2D().AddRelativeForce(Vector3.up * v * speed.GetSpeed().speed);
            rigidBody.GetRigidBody2D().AddRelativeForce(Vector3.right * h * speed.GetSpeed().speed);
        }



        if ((lastSpawnedAmmoTime + spawnAmmoInterval) < timeAmmoCounter)
        {
            timeAmmoCounter = 0;
            shoot.shoot();
        }

    }
}
