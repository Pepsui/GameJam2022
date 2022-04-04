using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menus : MonoBehaviour
{
    void Start() {
        Pause();
        Resume();
    }
    bool gamePaused;
    void Pause() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            gameObject.SetActive(true);
	        Time.timeScale = 0f;
	        gamePaused  = true;
        }
    }

    void Resume() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            gameObject.SetActive(false);
	        Time.timeScale = 1f;
	        gamePaused = false;
        }
    }
}
