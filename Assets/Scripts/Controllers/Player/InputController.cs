using Assets.Scripts.Base;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Interfaces.Player;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private IRigidBody rigidBody;
    private Speed speed;
    private IShoot shoot;

    public static int gameEnemies = 0;
    public static int gameAsteroids = 0;
    private float lastSpawnedAmmoTime;
    private float lastSpawnedAsteroidTime;
    private float lastSpawnedEnemyTime;
    private float timeAmmoCounter;
    private float timeAsteroidCounter;
    private float timeEnemyCounter;
    private double spawnAmmoInterval = 1;


    private void Start()
    {
        rigidBody = GameObject.FindGameObjectWithTag("Player").GetComponent<IRigidBody>();
        speed = GameObject.FindGameObjectWithTag("Player").GetComponent<Entity>().speed;
        shoot = GameObject.FindGameObjectWithTag("Player").GetComponent<IShoot>();
    }

    private void Update()
    {
        timeAmmoCounter += Time.deltaTime;
        float h = speed.rotateSpeed * Input.GetAxisRaw("Horizontal");
        float v = speed.rotateSpeed * Input.GetAxisRaw("Vertical");

        rigidBody.GetRigidBody2D().AddRelativeForce(Vector3.up * v * speed.speed);
        rigidBody.GetRigidBody2D().AddRelativeForce(Vector3.right * h * speed.speed);

        if ((lastSpawnedAmmoTime + spawnAmmoInterval) < timeAmmoCounter)
        {
            timeAmmoCounter = 0;
            shoot.shoot();
        }
        
    }
}
