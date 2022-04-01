using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //���_��\������e�L�X�g
    private GameObject gameScoreText;

    //score�ɕϐ�0����
    private int score = 0;

    //�Փˑ���̏����擾
    private void OnCollisionEnter(Collision other)
    {
        //�^�O�ɂ���ďՓˎ��̃X�R�A�𕪂���
        if (other.gameObject.CompareTag("SmallStarTag"))
        {
            this.score += 1;
        }
        else if (other.gameObject.CompareTag("LargeStarTag"))
        {
            this.score += 10;
        }
        else if (other.gameObject.CompareTag("SmallCloudTag"))
        {
            this.score += 500;
        }
        else if (other.gameObject.CompareTag("LargeCloudTag"))
        {
            this.score += 1000;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������gameScoreText�I�u�W�F�N�g���擾
        this.gameScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //gameScoreText��score��\��
        this.gameScoreText.GetComponent<Text>().text = "score:" + score;
    }



}
