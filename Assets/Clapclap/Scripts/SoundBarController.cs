using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundBarController : MonoBehaviour
{
  public float sensibility;
  public RectTransform barSize;
  public Image bar;

  public void UpdateBar (float level)
  {
    float x = Screen.width / 5;
    float y = Screen.height * level;
    Vector2 size = new Vector2(x, y);
    barSize.sizeDelta = size;
    bar.color = (level >= sensibility)? Color.green: Color.gray;
  }
}
