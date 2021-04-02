using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//здесь добавленный все методы которые привязанны к кнопкам внутрий Canvas
public class SettingsUIMethods : MonoBehaviour
{
    public GameObject settingsMenu;

    public void TurnOnSettingsMenu()
    {
        settingsMenu.SetActive(true);
        StartCoroutine(StopTime());
    }

    public IEnumerator StopTime()
    {
        while (Time.timeScale > 0.4)
        {
            yield return null;
            Time.timeScale -= 0.2f;
        }
        Time.timeScale = 0f;
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }

    public void CloseSettingsMenu()
    {
        Time.timeScale = 1f;
        settingsMenu.SetActive(false);
    }
}
