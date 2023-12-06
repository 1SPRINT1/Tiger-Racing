using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class ScoreforTimer : MonoBehaviour
{
   public Text scoreText;
   public Text scoreGMtext;
   public float timeElapsed = 0f;
   public int score = 0;
   public Player PL;
   [Space(30)] [Header("Score")] 
   public int oldScore;

   private void Start()
   {
       oldScore = PlayerPrefs.GetInt("Score");
   }

   private void Update()
   {
       oldScore = PlayerPrefs.GetInt("Score");
       if (oldScore < score)
       {
            PlayerPrefs.SetInt("Score",oldScore);   
       }
       if (PL.CurrentHealth > 0)
       {
           timeElapsed += Time.deltaTime;                       
           score = Mathf.RoundToInt(timeElapsed * 1);           
           scoreText.text = "Score: " + score.ToString("#");       
       }

       scoreGMtext.text = "Score: " + score.ToString("#");
   }
}
