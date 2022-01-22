using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Data", menuName ="ScriptableObject/DataServer", order = 1)]

public class DataServer : ScriptableObject
{
    public string PlayerName;
    public int score;
    public bool Lost;
}
