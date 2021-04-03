using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "DialogTamplate", order = 52)]
public class DialogTamplate : ScriptableObject
{
    public Dialog[] dialogs;
}

[System.Serializable]
public class Dialog
{
    public Sprite human;
    public Sprite fishman;
    [Space(25)]
    public Speekers[] whoSpeaks;
    [TextArea(3, 10)]
    public string[] question;
    [Space(25)]
    public Answer Ybutton;
    [Space(10)]
    public Answer Nbutton;
    [Space(25)]
    public GameObject[] addedItem;
    public GameObject[] removedItem;
}

[System.Serializable]
public class Answer
{
    public string buttonText;
    public int carma;
    public Speekers[] whoSpeaks;
    [TextArea(3, 10)]
    public string[] answer;
}

public enum Speekers
{
    Me,
    Opponent
}