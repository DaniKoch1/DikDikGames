using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPersistance : MonoBehaviour {

	public static void LoadData(){
        int score = PlayerPrefs.GetInt("score");
        int highscore = PlayerPrefs.GetInt("highscore");
        float speedOfArrows = PlayerPrefs.GetFloat("speedOfArrows");
        float waitingTime = PlayerPrefs.GetFloat("waitingTime");

        ScoreManager.Instance.score = score;
        ScoreManager.Instance.SetScore();
        ScoreManager.Instance.highscore = highscore;
        ArrowManager.speedOfArrows = speedOfArrows;
        ArrowManager.waitingTime = waitingTime;
    }
    public static void SaveData(){
        PlayerPrefs.SetInt("score", ScoreManager.Instance.totalScore);
        PlayerPrefs.SetInt("highscore", ScoreManager.Instance.highscore);
        PlayerPrefs.SetFloat("speedOfArrows", ArrowManager.speedOfArrows);
        PlayerPrefs.SetFloat("waitingTime", ArrowManager.waitingTime);
    }
    public static void ResetData(){
        PlayerPrefs.SetInt("score", 0);
       // ScoreManager.Instance.ResetScore();
        PlayerPrefs.SetInt("highscore", ScoreManager.Instance.highscore);
        PlayerPrefs.SetFloat("speedOfArrows", 0.1f);
        PlayerPrefs.SetFloat("waitingTime", 2);
    }
}
