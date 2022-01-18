using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DataSaver", order = 1)]
public class DataSaver : ScriptableObject
{
    public string name;
    public int score;
}
