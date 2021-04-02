using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MenuUIMethods : MonoBehaviour
{

    public Transform mytransform;
    public AnimationCurve curve;
    public int miliSeconds;
    public void LoadGame()
    {
        StartCoroutine(Gradient());
    }

    public IEnumerator Gradient()
    {
        AsyncOperation loadScene = SceneManager.LoadSceneAsync(1);
        loadScene.allowSceneActivation = false;

        for(float i =0; i < 1f; i += 1f/miliSeconds)
        {
            mytransform.localScale += new Vector3(curve.Evaluate(i), curve.Evaluate(i), 0);
            yield return new WaitForSeconds(0.01f);
        }
        loadScene.allowSceneActivation = true;



    }
}
