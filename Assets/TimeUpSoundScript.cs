using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeUpSoundScript : MonoBehaviour
{
    public int A;
    private AudioSource audioSource; // �I�[�f�B�I�\�[�X
    public AudioClip timeUpSound; // �^�C���A�b�v�̉�
    TimeTextScript TimeTextScript;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obe = GameObject.Find("TimeText");
        TimeTextScript = obe.GetComponent<TimeTextScript>();

        if (TimeTextScript.T < 0 && A == 0)
        {
            audioSource.PlayOneShot(timeUpSound);
            A = 1;
        }
    }
}
