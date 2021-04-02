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

    private void Awake()
    {
        instance = this;
    }

}
