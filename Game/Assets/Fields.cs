using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fields : MonoBehaviour
{
    //синглтон кому нужен
    public static Fields instance;
    public SDSample saveData;
    public GameObject tutorial;
    public Image darkScreen;
    public Cahracters charactersSprites;
    private void Awake()
    {
        instance = this;
    }
}

[System.Serializable]
public class Cahracters
{
    CahracterSprites гопники;
    CahracterSprites бабки;
    CahracterSprites начальник;
    CahracterSprites капитан;
    CahracterSprites бомж;
    CahracterSprites продовщица;
    CahracterSprites гопбаба;
    CahracterSprites говнарь;
    CahracterSprites девочка;
    CahracterSprites гг;
    CahracterSprites ггрыба;
}


[System.Serializable]
public class CahracterSprites
{
    Sprite Man;
    Sprite FishMan;
    Sprite Fish;
}