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
    public Characters opponent;
    [TextArea(3, 10)]
    public string[] question;
    public Answer Ybutton;
    public Answer Nbutton;
    [Space(20)]
    public GameObject addedItem;
    public GameObject removedItem;
}

[System.Serializable]
public class Answer
{
    public string buttonText;
    public int carma;
    [TextArea(3, 10)]
    public string[] answer;
}

public enum Characters
{
    гопники,
    бабки,
    начальник,
    капитан,
    бомж,
    продовщица,
    гопбаба,
    говнарь,
    девочка,
    гг,
    ггрыба
}