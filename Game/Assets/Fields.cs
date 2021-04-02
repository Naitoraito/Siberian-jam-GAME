using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fields : MonoBehaviour
{
    //синглтон кому нужен
    public static Fields instance;
    public SDSample saveData;
    public GameObject tutorial;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if(saveData.isFirstGameOpen == true)
        {
            Instantiate<GameObject>(tutorial);
            saveData.isFirstGameOpen = false;
        }
    }
}
