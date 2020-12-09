using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;

    public void SetMasterVolume(float value)
    {
        mixer.SetFloat("masterVol", value);
        print(value);
    }

    public void SetBgmVolume(float value)
    {
        mixer.SetFloat("musicVol", value);
    }
}
