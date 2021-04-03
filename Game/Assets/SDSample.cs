using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SaveData", menuName = "SaveData", order = 51)]
public class SDSample : ScriptableObject
{
    public bool isFirstGameOpen;
    [Range(1, 3)]
    public int Day = 1;
    [Range(0, 100)]
    public int Carma;
}
