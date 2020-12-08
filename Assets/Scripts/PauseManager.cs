using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused;

    [SerializeField]
    private GameObject pausePanel = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    private void Pause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0.0f : 1.0f;
        pausePanel.SetActive(isPaused);
    }
}
