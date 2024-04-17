using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  public AudioSource musicSource;
  public AudioClip[] musicClips;
  private int currentClipIndex = 0;

  void Start()
  {

    currentClipIndex = 0;
    musicSource.clip = musicClips[currentClipIndex];
    musicSource.Play();
  }
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      // Update clip index
      currentClipIndex = (currentClipIndex + 1) % musicClips.Length;

      // Assign new clip and play
      musicSource.clip = musicClips[currentClipIndex];
      musicSource.Play();
    }
  }
}
