using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip coinSound;
    static AudioSource audioSource;
    void Start()
    {
        // coinSound = Load<AudioClip>("Coin");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void PlayCoin()
    {
        audioSource.Play();
    }
}
