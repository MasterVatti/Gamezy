using System.Collections.Generic;
using UnityEngine;

namespace CodeBase
{
  [CreateAssetMenu(menuName = "Movies/Data", fileName = "Movies")]
  public class MoviesInformation : ScriptableObject
  {
    [SerializeField] private List<MoviesData> _data;

    public List<MoviesData> Data => _data;
  }
}