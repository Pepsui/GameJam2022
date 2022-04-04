using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTraversal : MonoBehaviour
{
    [SerializeField] string sceneName;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") {
            ToNextScene(sceneName);
        }
    }

    private void ToNextScene(string sceneName)
    {
        
        SceneManager.LoadScene(sceneName);
        StartCoroutine(PortalRefresh());
    }

    IEnumerator PortalRefresh() {
        yield return new WaitForSeconds(20);
    }

}
