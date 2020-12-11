using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;
    [SerializeField] private GameObject lifeGameObject = null;
    [SerializeField] private Image lifebarFill = null;
    [SerializeField] private int maxHealth = 3;


    void OnEnable()
    {
        EventController.addPoints += UpdateScore;
        EventController.removeLife += UpdateHealth;
    }

    void OnDisable()
    {
        EventController.addPoints -= UpdateScore;
        EventController.removeLife -= UpdateHealth;
    }




    public void UpdateScore(int score)
    {
        scoreText.text = $"Pontuação: {score}";
    }

    public void UpdateHealth(int health)
    {
        print(health);
        lifebarFill.fillAmount = (float)health / maxHealth;
    }
}
