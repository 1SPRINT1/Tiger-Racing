using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
   [HideInInspector] [SerializeField] private int Money;
 //  [HideInInspector] [SerializeField] private int Stamina;
   [HideInInspector] [SerializeField] private int Speed;
    [HideInInspector] [SerializeField] private int Score;
    [HideInInspector] [SerializeField] private int Prolog;
    void Start()
    {
        Money = PlayerPrefs.GetInt("Money");
    //    Stamina = PlayerPrefs.GetInt("Stamina");
        Speed = PlayerPrefs.GetInt("Speed");
        Score = PlayerPrefs.GetInt("Score");
        Prolog = PlayerPrefs.GetInt("Prolog");
    }
    void Update()
    {
        Money = PlayerPrefs.GetInt("Money");
   //     Stamina = PlayerPrefs.GetInt("Stamina");
        Speed = PlayerPrefs.GetInt("Speed");
        Score = PlayerPrefs.GetInt("Score");
        Prolog = PlayerPrefs.GetInt("Prolog");
    }
}
