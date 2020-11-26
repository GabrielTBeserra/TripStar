using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Limite de X e Y do lado esquerdo da camera
    public static Vector2 leftLimit;
    // Limite de X e Y do lado direito da camera
    public static Vector2 rightLimit;

    [SerializeField]
    public GameObject enemy;

    public int EnemyMaxNumber;
    public int Enemies;



    void Start()
    {
        Camera mainCamera = Camera.main;
        leftLimit = mainCamera.ScreenToWorldPoint(new Vector3(0, 1, 0));
        rightLimit = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    void Update()
    {

        // Instantiate(enemy, new Vector2(Random.Range(leftLimit.x, rightLimit.x), rightLimit.y + 5), new Quaternion());
    }
}
