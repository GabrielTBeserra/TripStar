using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;
    [SerializeField] private GameObject lifeGameObject = null;

    public void UpdateScore(int score)
    {
        scoreText.text = $"Pontuação: {score}";
    }
}
