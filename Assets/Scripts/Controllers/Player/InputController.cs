using Assets.Scripts.Base;
using Assets.Scripts.Interfaces.Player;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private IRigidBody rigidBody;
    private Speed speed;

    private void Start()
    {
        rigidBody = GameObject.FindGameObjectWithTag("Player").GetComponent<IRigidBody>();
        speed = GameObject.FindGameObjectWithTag("Player").GetComponent<Entity>().speed;
    }

    private void Update()
    {
        float h = speed.rotateSpeed * Input.GetAxisRaw("Horizontal");
        float v = speed.rotateSpeed * Input.GetAxisRaw("Vertical");

        rigidBody.GetRigidBody2D().AddRelativeForce(Vector3.up * v * speed.speed);
        rigidBody.GetRigidBody2D().AddRelativeForce(Vector3.right * h * speed.speed);
    }
}
