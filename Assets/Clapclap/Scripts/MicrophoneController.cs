using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicrophoneController : MonoBehaviour
{
  public SoundBarController soundBar;

  private AudioClip _clip;

  public void Update ()
  {
    if (!Microphone.IsRecording(null))
    { _clip = Microphone.Start(null, true, 1, 44100); }
    
    soundBar.UpdateBar(GetSoundLevel());
  }

  private float GetSoundLevel ()
  {
    float[] samples = new float[_clip.samples * _clip.channels];
    _clip.GetData(samples, 0);

    float maxLevel = 0;
    foreach (float sample in samples)
    { maxLevel = (sample > maxLevel)? sample: maxLevel; }

    return maxLevel;
  }
}
