using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("Score")]
    public Text _scoreText;
    [SerializeField] private int Score;
    private void Update()
    {
        _scoreText.text = Score.ToString("#");
        Score = PlayerPrefs.GetInt("Score");
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }
    }
    public void StartRacing()
    {
        SceneManager.LoadScene("Game");
    }
    public void UpgradeStart()
    {
        SceneManager.LoadScene("Upgrade");
    }

}
