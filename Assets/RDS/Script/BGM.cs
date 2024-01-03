using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip Bgm;
    void Start()
    {
        Debug.Log("������ ����");
        //SoundManager.instance.Play(Bgm, this.transform, true);

        // ���� �����
        SoundManager.instance.audioSource.clip = Bgm;
        SoundManager.instance.audioSource.Play();
    }
    public void ExchangeBGM(bool isloop , AudioClip NextAudio = null )
    {
        SoundManager.instance.RetrunPool(GetComponentInChildren<SoundComponet>().gameObject);
        SoundManager.instance.Play(NextAudio, this.transform,isloop);
    }
    public void RemoveBGM()
    {
        SoundManager.instance.RetrunPool(GetComponentInChildren<SoundComponet>().gameObject);
    }
}
