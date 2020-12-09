using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource source = null;
    [SerializeField] private AudioClip fireClip = null;

    public void PlayShoot()
    {
        source.PlayOneShot(fireClip);
    }
}
