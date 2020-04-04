using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundEffect : MonoBehaviour
{
    public AudioClip sonidoDisparo, sonidoMuerte;

    private AudioSource emisorAudio;

    // Start is called before the first frame update
    void Start()
    {
        emisorAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayShoot()
    {
        emisorAudio.PlayOneShot(sonidoDisparo);
    }

    public void PlayDead()
    {
        emisorAudio.PlayOneShot(sonidoMuerte);
    }
}
