using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
  public GameObject effects;
  public Transform position1;
  public bool isEnd = false;
  public Player PL;
  public void EndStartEffect()
  {
    Instantiate(effects, position1.position, Quaternion.identity);
    isEnd = true;
    Time.timeScale = 0f;
    PL.MoneyPlusButton();
  }

  public void GoHome()
  {
    SceneManager.LoadScene("Menu");
  }
}
