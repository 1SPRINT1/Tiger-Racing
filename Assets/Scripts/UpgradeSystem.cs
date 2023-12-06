using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour
{
   [Header("Money")] 
   public Text textMoney;
   [HideInInspector] [SerializeField] private int Money;
   [Space(30)] 
   [Header("Stamina")] 
   public Text textPurchasedStamina;
   [HideInInspector] [SerializeField] private int Stamina;
   public bool isPurchasedStamina = false;
   [Space(30)]
   [Header("Speed")] 
   public Text textPurchasedSpeed;
   [HideInInspector] [SerializeField] private int Speed;
   public bool isPurchasedSpeed = false;
   [Header("Effects")] 
   public GameObject effect1;
   public GameObject effect2;

   private void Update()
   {
      Speed = PlayerPrefs.GetInt("Speed");
      Money = PlayerPrefs.GetInt("Money");
      if (Speed > 0)
      {
         textPurchasedSpeed.text = Speed.ToString("#");  
      }
      textMoney.text = Money.ToString("#");
      if (isPurchasedSpeed == true)
      {
         if (Money >= 300)
         {
            Speed++;
            textPurchasedSpeed.text = Speed.ToString("#");
            Money -= 300;
            textMoney.text = "Money: " + Money.ToString("#");
            isPurchasedSpeed = false;
            PlayerPrefs.SetInt("Speed",Speed);
            Instantiate(effect1, transform.position, Quaternion.identity);
         }
      }
   }
   

   public void BuySpeed()
   {
      isPurchasedSpeed = true;
   }

   public void BackToHome()
   {
      SceneManager.LoadScene("Menu");
   }
}