using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Spin : MonoBehaviour
{
    [SerializeField] Image spiral;
    // Start is called before the first frame update

    void SpinImage() {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
    }

    public void NewGameButton() {
        SceneManager.LoadScene("StartingScene");
    }

    public void ExitGameButton() {
        Application.Quit();
    }
}
