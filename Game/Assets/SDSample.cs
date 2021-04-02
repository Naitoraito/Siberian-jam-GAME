using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SaveData", menuName = "SaveData", order = 51)]
public class SDSample : ScriptableObject
{
    public bool isFirstGameOpen;
    public int Day = 1;
}
