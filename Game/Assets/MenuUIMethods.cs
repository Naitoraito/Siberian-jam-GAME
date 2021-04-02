using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MenuUIMethods : MonoBehaviour
{
<<<<<<< HEAD
=======
    public RectTransform transform;
>>>>>>> 7f9198a714f7d23e61c7644316f263e1f22ad2e0
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
