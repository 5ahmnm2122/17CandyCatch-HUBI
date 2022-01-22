using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteName : MonoBehaviour
{

    public DataServer data;
    public Text Name;



    public void StartGame ()
    {
        data.PlayerName = Name.text;




    }
}
