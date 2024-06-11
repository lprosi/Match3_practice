using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource[] destroySound;

    public void PlayRandomDestroySound()
    {
        if (PlayerPrefs.HasKey("Sound"))
        {
            if(PlayerPrefs.GetInt("Sound") == 1)
            {
                //������� ��������� �����
                int clipToPlay = Random.Range(0, destroySound.Length);
                //�������� ����
                destroySound[clipToPlay].Play();
            }
        }
        else
        {
            //������� ��������� �����
            int clipToPlay = Random.Range(0, destroySound.Length);
            //�������� ����
            destroySound[clipToPlay].Play();
        }

    }

}
