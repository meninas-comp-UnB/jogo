using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  public AudioSource sons;
  public static AudioManager inst = null;

  void Awake() {
    if(inst == null) {
      inst = this;
    }
    else if (inst != this) {
      Destroy(gameObject);
    }
  }

  public void PlayAudio (AudioClip clipAudio) {
    sons.clip = clipAudio;
    sons.Play();
  }
}
