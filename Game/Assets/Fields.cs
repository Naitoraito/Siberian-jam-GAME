using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fields : MonoBehaviour
{
    //�������� ���� �����
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
    CahracterSprites �������;
    CahracterSprites �����;
    CahracterSprites ���������;
    CahracterSprites �������;
    CahracterSprites ����;
    CahracterSprites ����������;
    CahracterSprites �������;
    CahracterSprites �������;
    CahracterSprites �������;
    CahracterSprites ��;
    CahracterSprites ������;
}


[System.Serializable]
public class CahracterSprites
{
    Sprite Man;
    Sprite FishMan;
    Sprite Fish;
}