using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSystem : MonoBehaviour
{
   public GameObject TutorButton1;
   public GameObject TutorButton2;
   public GameObject Tutor1;
   public GameObject Tutor2;
   public GameObject TutorialPanel;
   public AudioSource AU;
   public int tutorialComplete;

   private void Update()
   {
      tutorialComplete = PlayerPrefs.GetInt("Prolog");
      if (tutorialComplete == 1)
      {
         TutorialPanel.SetActive(false);
      }
   }

   public void EnterTutorial1()
   {
      TutorButton1.SetActive(false);
      Tutor1.SetActive(false);
      Tutor2.SetActive(true);
      TutorButton2.SetActive(true);
      AU.Play();
   }

   public void EnterTutorial2()
   {
      TutorButton2.SetActive(false);
      Tutor2.SetActive(false);
      TutorialPanel.SetActive(false);
      tutorialComplete = 1;
      PlayerPrefs.SetInt("Prolog",tutorialComplete);
   }
}
