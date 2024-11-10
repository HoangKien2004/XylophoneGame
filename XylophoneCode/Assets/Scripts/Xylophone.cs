using UnityEngine;

public class Xylophone : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] tones;
    private AudioSource audioSrc;
    void Start()
    {
        Tone.ToneClicked += PlaySound;
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnDestroy()
    {
        Tone.ToneClicked -= PlaySound;
    }

    private void PlaySound(string noName)
    {
        switch (noName)
        {
            case "A_tone":
                audioSrc.PlayOneShot(tones[0]);
                break;
            case "B_tone":
                audioSrc.PlayOneShot(tones[1]);
                break;
            case "C_tone":
                audioSrc.PlayOneShot(tones[2]);
                break;
            case "D_tone":
                audioSrc.PlayOneShot(tones[3]);
                break;
            case "E_tone":
                audioSrc.PlayOneShot(tones[4]);
                break;
            case "F_tone":
                audioSrc.PlayOneShot(tones[5]);
                break;
            case "G_tone":
                audioSrc.PlayOneShot(tones[6]);
                break;
            case "C2_tone":
                audioSrc.PlayOneShot(tones[7]);
                break;
        }
    }
}
