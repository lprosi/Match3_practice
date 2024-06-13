using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource[] destroySound;
    public AudioSource backgroundMusic;


    private void Start()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            if (PlayerPrefs.GetInt("Sound") == 0)
            {
                backgroundMusic.Play();
                backgroundMusic.volume = 0;
            }
            else
            {
                backgroundMusic.Play();
                backgroundMusic.volume = 0.5f;
            }
        }
        else
        {
            backgroundMusic.Play();
            backgroundMusic.volume = 0.5f;
        }
    }

    public void AdjustVolume()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            if (PlayerPrefs.GetInt("Sound") == 0)
            {
                backgroundMusic.volume = 0;
            }
            else
            {
                backgroundMusic.volume = 0.5f;
            }
        }
    }

    public void PlayRandomDestroySound()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            if(PlayerPrefs.GetInt("Sound") == 1)
            {
                //выбрать случайное число
                int clipToPlay = Random.Range(0, destroySound.Length);
                //включить звук
                destroySound[clipToPlay].Play();
            }
        }
        else
        {
            //выбрать случайное число
            int clipToPlay = Random.Range(0, destroySound.Length);
            //включить звук
            destroySound[clipToPlay].Play();
        }

    }

}
