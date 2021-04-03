using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    int carma = 0;
    void Update()
    {
        if(carma != Fields.instance.saveData.Carma)
        {
            carma = Fields.instance.saveData.Carma;
            Fields.instance.carmaSlider.value = Fields.instance.saveData.Carma;
        }
    }
}
