using UnityEngine;
using System;

namespace CodeBase
{
  [Serializable]
  public class MoviesData
  {
    public Sprite Image;
    public string Title;
    public string Text;

    public MoviesData(Sprite image, string title, string text)
    {
      Image = image;
      Title = title;
      Text = text;
    }
  }
}