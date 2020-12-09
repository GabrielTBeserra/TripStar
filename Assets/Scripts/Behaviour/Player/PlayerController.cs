using Assets.Scripts.Base;
using Assets.Scripts.Interfaces.Player;
using UnityEngine;

public class PlayerController : Entity, IMove, ITransform, IRigidBody, IShoot, ISpeed
{

    private Transform transform;
    private Rigidbody2D rigidbody2D;



    [SerializeField]
    private Transform FireSpot;
    [SerializeField]
    private GameObject bulletPrefab;

    private void Start()
    {
        speed = new Speed(2f, 2f);
        transform = GetComponent<Transform>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckLimits();
    }


    public void move()
    {

    }

    public Rigidbody2D GetRigidBody2D()
    {
        return this.rigidbody2D;
    }

    public Transform GetTransform()
    {
        return this.transform;
    }

    public void shoot()
    {
        gameObject.GetComponent<SoundController>().PlayShoot();
        GameObject bulletGo = Instantiate(bulletPrefab, FireSpot.position, FireSpot.rotation);
    }

    public Speed GetSpeed()
    {
        return this.speed;
    }

    public void CheckLimits()
    {
        if (transform.position.x > GameManager.rightLimit.x)
        {
            rigidbody2D.AddForce(new Vector2(-3, 0));
            rigidbody2D.velocity = Vector2.zero;
        }
        else if (transform.position.x < GameManager.leftLimit.x)
        {
            rigidbody2D.AddForce(new Vector2(3, 0));
            rigidbody2D.velocity = Vector2.zero;
        }
        else if (transform.position.y > GameManager.rightLimit.y)
        {
            rigidbody2D.AddForce(new Vector2(0, -3));
            rigidbody2D.velocity = Vector2.zero;
        }
        else if (transform.position.y < GameManager.leftLimit.y)
        {
            rigidbody2D.AddForce(new Vector2(0, 3));
            rigidbody2D.velocity = Vector2.zero;
        }

        rigidbody2D.rotation = 0;
    }
}
