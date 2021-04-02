using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MenuUIMethods : MonoBehaviour
{

    public RectTransform mytransform;
    public void LoadGame()
    {
        StartCoroutine(Gradient());
    }

    public IEnumerator Gradient()
    {
        while (mytransform.localScale.x <= 3)
        {
            
            yield return new WaitForSeconds(0.05f);
            mytransform.localScale += new Vector3(0.05f, 0.05f, 0);
            
        }
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadSceneAsync(1);
        
        
    }
}
