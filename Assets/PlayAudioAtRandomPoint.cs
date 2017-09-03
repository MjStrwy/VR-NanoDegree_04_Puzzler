using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioAtRandomPoint : MonoBehaviour {

    public AudioSource soundToPlay;
    public float randomStartingTime;

    void Start()
    {
        randomStartingTime = Random.Range(0f, 10f);
        PlaySound();
    }

    void PlaySound()
    {
        soundToPlay.time = randomStartingTime;
        soundToPlay.Play();
    }

    void Update()
    {

        print  (soundToPlay.time);
    }
}