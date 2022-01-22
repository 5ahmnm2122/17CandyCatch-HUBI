using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoose : MonoBehaviour
{
   public Text PlayerName;
   public Text WinOrLoose;
   public Text Score;
   public DataServer data;

   void Start()
   {
       PlayerName.text = data.PlayerName;
       Score.text = data.score.ToString();

       if (data.Lost)
       {
           WinOrLoose.text = "Verloren";
       }
       else
       {
           WinOrLoose.text = "Gewonnen";
       }
   }
}
