using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIMethods : MonoBehaviour
{
    public void GoOut()
    {
        switch(Fields.instance.saveData.Day)
        {
            case 1:
                Camera.main.transform.position = new Vector3(0,11,-10);
                break;
            case 2:
                Camera.main.transform.position = new Vector3(0, 22, -10);
                break;
            case 3:
                Camera.main.transform.position = new Vector3(0, 33, -10);
                break;
        }

    }

}
