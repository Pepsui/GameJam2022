using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    [SerializeField] AudioSource WorldSound;
    // Start is called before the first frame update

    void Start()
    {
        WorldSound = GetComponent<AudioSource>();

        WorldSound.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
 //       StartCoroutine(FadeOut(WorldSound, 3.0f));
    }

 /*   void FadeSound() {
        IEnumerator FadeOut (AudioSource audioSource, float FadeTime) {
        float startVolume = audioSource.volume;
 
        while (audioSource.volume > 0) {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.Stop ();
        audioSource.volume = startVolume;
    }
 
    } */
}
