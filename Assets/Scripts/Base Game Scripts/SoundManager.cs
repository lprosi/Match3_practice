using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource[] destroySound;

    public void PlayRandomDestroySound()
    {
        //выбрать случайное число
        int clipToPlay = Random.Range(0, destroySound.Length);
        //включить звук
        destroySound[clipToPlay].Play();
    }

}
