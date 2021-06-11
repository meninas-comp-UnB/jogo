using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  public GameObject SoltaOsom;
  public static AudioManager inst = null;

  void Awake() {
    if( SoltaOsom.GetInt("BoolButtonMusica") == 1) {
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
