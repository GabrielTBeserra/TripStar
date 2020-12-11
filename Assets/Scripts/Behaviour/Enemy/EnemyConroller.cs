using Assets.Scripts.Base;
using Assets.Scripts.Interfaces.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConroller : Entity, IMove, ITransform, IRigidBody, IShoot, ISpeed
{
    [SerializeField]
    public GameObject FireSpot;

    [SerializeField]
    public GameObject bullet;

    private PlayerController player;
    private Rigidbody2D rigidbody2D;
    private Transform transform;
    private bool isFalling;


    public static int gameEnemies = 0;
    public static int gameAsteroids = 0;
    private float lastSpawnedAmmoTime;
    private float timeAmmoCounter;
    private double spawnAmmoInterval = 1;

    void Start()
    {
        isFalling = false;
        transform = GetComponent<Transform>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {

        if (!isFalling)
        {
            if (transform.position.y < GameManager.rightLimit.y - 3)
            {
                rigidbody2D.gravityScale = 0.0f;
                rigidbody2D.velocity = Vector2.zero;
                isFalling = true;
            }

        } 
        else
        {
            rigidbody2D.AddForce(new Vector2(Random.Range(-3, 3), 0));
        }

        CheckLimits();

    }

    void FixedUpdate()
    {
        timeAmmoCounter += Time.deltaTime;
       
        if ((lastSpawnedAmmoTime + spawnAmmoInterval) < timeAmmoCounter)
        {
            timeAmmoCounter = 0;
            Shoot();
        }
    }

    public Rigidbody2D GetRigidBody2D()
    {
        return this.rigidbody2D;
    }

    public Speed GetSpeed()
    {
        throw new System.NotImplementedException();
    }

    public Transform GetTransform()
    {
        return this.transform;
    }

    public void move()
    {
        throw new System.NotImplementedException();
    }

    public void shoot()
    {
        throw new System.NotImplementedException();
    }

    private void CheckLimits()
    {
       
        if (transform.position.x > GameManager.rightLimit.x)
        {
            rigidbody2D.AddForce(new Vector2(-3, 0));
        }
        else if (transform.position.x < GameManager.leftLimit.x)
        {
            rigidbody2D.AddForce(new Vector2(3, 0));
        }

    }



    private void Shoot()
    {
        
        GameObject asd = Instantiate(bullet, FireSpot.transform.position, FireSpot.transform.rotation);
        asd.tag = "EnemyBullet";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PlayerBullet"))
        {
            player.points.points++;
            EventController.addPoints(player.points.points);
            Destroy(gameObject);
        }

    }


}
