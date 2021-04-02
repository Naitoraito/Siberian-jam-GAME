using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MenuUIMethods : MonoBehaviour
{
    public void LoadGame()
    {
        StartCoroutine(Gradient());
    }

    public IEnumerator Gradient()
    {
        yield return new WaitForSeconds(1 / 10f);
        SceneManager.LoadSceneAsync(1);

    }
}
