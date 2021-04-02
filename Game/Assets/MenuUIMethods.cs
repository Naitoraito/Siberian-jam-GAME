using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIMethods : MonoBehaviour
{
    public RectTransform transform;
    public void LoadGame()
    {
        StartCoroutine(Gradient());
    }

    public IEnumerator Gradient()
    {
        while (transform.localScale.x <= 3)
        {
            
            yield return new WaitForSeconds(0.1f);
            transform.localScale += new Vector3(0.1f, 0.1f, 0);
            
        }
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadSceneAsync(1);
        
        
    }
}
