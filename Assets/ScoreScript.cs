using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //得点を表示するテキスト
    private GameObject gameScoreText;

    //scoreに変数0を代入
    private int score = 0;

    //衝突相手の情報を取得
    private void OnCollisionEnter(Collision other)
    {
        //タグによって衝突時のスコアを分ける
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
        //シーン中のgameScoreTextオブジェクトを取得
        this.gameScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //gameScoreTextにscoreを表示
        this.gameScoreText.GetComponent<Text>().text = "score:" + score;
    }



}
