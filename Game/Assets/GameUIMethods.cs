using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIMethods : MonoBehaviour
{
    public void DoorOut()
    {
        StartCoroutine(GoToDay(Fields.instance.saveData.Day));
    }

    public IEnumerator GoToDay(int day)
    {
        Image darkScreen = Fields.instance.darkScreen;
        darkScreen.gameObject.SetActive(true);

        for(int i = 0; i <= 100; i++)
        {
            darkScreen.color = new Color(0, 0, 0, i / 100f);
            yield return new WaitForSeconds(1 / 1000f);
        }

        switch (Fields.instance.saveData.Day)
        {
            case 1:
                Camera.main.transform.position = new Vector3(0, 11, -10);
                break;
            case 2:
                Camera.main.transform.position = new Vector3(0, 22, -10);
                break;
            case 3:
                Camera.main.transform.position = new Vector3(0, 33, -10);
                break;
        }

        for (int i = 100; i > 0; i--)
        {
            darkScreen.color = new Color(0, 0, 0, i / 100f);
            yield return new WaitForSeconds(1 / 1000f);
        }
        darkScreen.color = Color.clear;
        darkScreen.gameObject.SetActive(false);
    }
    public void AddedCarma(int carma)
    {
        SDSample saveData = Fields.instance.saveData;
        saveData.Carma += carma;
        saveData.Carma = Mathf.Clamp(saveData.Carma, 0, 100);
    }
    
    public void GoHome()
    {
        Camera.main.transform.position = new Vector3(0, 0, -10);
    }
    public void Restartlvl()
    {
        SceneManager.LoadSceneAsync(1);
        if (Fields.instance.saveData.Day < 3)
            Fields.instance.saveData.Day += 1;
    }
}
