using Assets.Scripts.Base;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Interfaces.Player;
using UnityEngine;

public class PlayerController : Entity, IMove, ITransform, IRigidBody , IShoot
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
        GameObject bulletGo = Instantiate(bulletPrefab, FireSpot.position, FireSpot.rotation);
    }
}
