using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "DialogTamplate", order = 52)]
public class DialogTamplate : ScriptableObject
{
    public Sprite character;
    public Sprite opponent;
    [TextArea(3, 10)]
    public string[] question;
    public string Ybutton;
    public string Nbutton;
    [TextArea(3, 10)]
    public string[] YAnswer;
    [TextArea(3, 10)]
    public string[] NAnswer;


}
