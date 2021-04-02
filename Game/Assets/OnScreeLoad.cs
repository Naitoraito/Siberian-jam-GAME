using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnScreeLoad : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Gradient());
    }

    void Update()
    {
        
    }

    public IEnumerator Gradient()
    {
        Image darkScreen = Fields.instance.darkScreen;
        darkScreen.gameObject.SetActive(true);

        for (int i = 100; i > 0; i--)
        {
            darkScreen.color = new Color(0, 0, 0, i / 100f);
            yield return new WaitForSeconds(1 / 1000f);
        }
        darkScreen.color = Color.clear;
        darkScreen.gameObject.SetActive(false);
    }
}
