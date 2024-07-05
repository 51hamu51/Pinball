using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissSoundScript : MonoBehaviour
{
    public int B;
    private AudioSource audioSource; // �I�[�f�B�I�\�[�X
    public AudioClip missSound; // �^�C���A�b�v�̉�
    // Start is called before the first frame update
    void Start()
    {
        B = 1;
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (B == 0)
        {
            audioSource.PlayOneShot(missSound);
            B = 1;
        }
    }
}
