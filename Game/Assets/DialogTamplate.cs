using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "DialogTamplate", order = 52)]
public class DialogTamplate : ScriptableObject
{
    public GameObject addedItem;
    public GameObject removedItem;
    [Space(20)]
    public Sprite characterSprite;
    public Sprite opponentSprite;
    [Space(20)]
    [TextArea(3, 10)]
    public string[] question;
    public Answer Ybutton;
    public Answer Nbutton;
}

[System.Serializable]
public class Answer
{
    public string buttonText;
    public int carma;
    [TextArea(3, 10)]
    public string[] answer;
}
