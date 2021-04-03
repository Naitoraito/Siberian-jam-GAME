using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checker : MonoBehaviour
{

    SDSample savedata;
    Slider slider;

    private void Start()
    {
        savedata = Fields.instance.saveData;
        slider = Fields.instance.carmaSlider;
    }


    void Update()
    {
        if(slider.value != savedata.Carma)
        {
            StartCoroutine(UpdateSlider());
        }
    }




    IEnumerator UpdateSlider()
    {
        while (slider.value != savedata.Carma)
        {
            slider.value = Mathf.MoveTowards(slider.value, savedata.Carma, 1f);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
