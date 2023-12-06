using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
   public bool isDown = false;
   public int Speed = 1;
   public int UpgradeSpeed;
   [Space(30)] 
   [Header("Positions")] 
   public Transform point1;
   public Transform point2;
   
   public Text scoreTEXT;

   [Space(30)] [Header("EndGame")] 
   public GameObject EndPanel;
   public GameObject MoveButton;
   [Header("Health")] 
   public int Health = 1;

   public int CurrentHealth = 1;
   public ScoreforTimer SFT;

   public GameObject Tutorial;
   public GameObject EndGamePanel;
   [Space(30)] 
   [Header("Money")] 
   public int curretMoney;
   public Text currentTextMoney;
   public int allMoney;
   public GameObject effectsMoney;

   public GameObject efectEnemy;

   public GameOver GO;

   [Space(30)]
   [Header("Combo")]
   public GameObject ComboPlate;
   public GameObject ComboPlate2;
   public Text textCombo;
   public int combo;

   private void Start()
   {
       UpgradeSpeed = PlayerPrefs.GetInt("Speed");
       Speed += UpgradeSpeed;
       allMoney = PlayerPrefs.GetInt("Money");
   }

   private void Update()
   {
       allMoney = PlayerPrefs.GetInt("Money");
       curretMoney = SFT.score;
      // Stamina -= enabledStamina * Time.deltaTime;
       if (isDown == true)
       {
           transform.position = Vector3.MoveTowards(transform.position, point2.position, Speed * Time.deltaTime);
       }

       if (isDown == false)
       {
           transform.position = Vector3.MoveTowards(transform.position, point1.position, Speed * Time.deltaTime);
       }

       if (CurrentHealth <= 0)
       {
           EndPanel.SetActive(true);
           MoveButton.SetActive(false);
           if (SFT.oldScore < SFT.score)
           {
               SFT.oldScore += SFT.score;
               PlayerPrefs.SetInt("Score",SFT.oldScore);
           }
       }

       if (Tutorial.activeSelf == true || GO.isEnd == true)
       {
           Time.timeScale = 0;
       }

       if (Tutorial.activeSelf == false && EndGamePanel.activeSelf == false && GO.isEnd == false)
       {
           Time.timeScale = 1;
       }
       Health = PlayerPrefs.GetInt("Health");
       UpgradeSpeed = PlayerPrefs.GetInt("Speed");
       if (combo > 3)
       {
           ComboPlate.SetActive(true);
           ComboPlate2.SetActive(true);
           textCombo.text = "Combo: " + combo.ToString("X#");
       }
        
       currentTextMoney.text = curretMoney.ToString("#");
   }

   private void OnCollisionEnter2D(Collision2D other)
   {
       if (other.gameObject.CompareTag("Enemy"))
       {
           CurrentHealth--;
           Destroy(other.gameObject);
           Instantiate(efectEnemy, transform.position, Quaternion.identity);
       }

       if (other.gameObject.CompareTag("Coin"))
       {
           SFT.score++;
           Instantiate(effectsMoney, transform.position, Quaternion.identity);
           Destroy(other.gameObject);
           combo++;
       }  
   }

   public void DownButton()
   {
       isDown = !isDown;
   }

   public void MoneyPlusButton()
   {
       allMoney += curretMoney;
       PlayerPrefs.SetInt("Money",allMoney);
   }
}
