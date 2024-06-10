using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource[] destroySound;

    public void PlayRandomDestroySound()
    {
        //������� ��������� �����
        int clipToPlay = Random.Range(0, destroySound.Length);
        //�������� ����
        destroySound[clipToPlay].Play();
    }

}
