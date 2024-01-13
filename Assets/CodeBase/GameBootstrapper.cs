using System.Threading.Tasks;
using UnityEngine;

namespace CodeBase
{
  public class GameBootstrapper : MonoBehaviour
  {
    [SerializeField] private GameObject _curtainPrefab;
    [SerializeField] private ScenesLoader _scenesLoader;

    private const string Initial = "Initial";
    private const string Game = "Game";

    private LoadingCurtain _curtain;

    private void Awake()
    {
      _curtain = Instantiate(_curtainPrefab).GetComponent<LoadingCurtain>();
      LoadFirstScene();
      DontDestroyOnLoad(this);
    }

    private void LoadFirstScene() => _scenesLoader.Load(Initial, EnterLoadLevel);

    private void EnterLoadLevel()
    {
      _curtain.Show();
      _scenesLoader.Load(Game, OnLoaded);
    }

    private async void OnLoaded()
    {
      await InitDependencies();
      _curtain.Hide();
    }

    private async Task InitDependencies() => FindObjectOfType<UIController>().Initialize(LoadFirstScene);
  }
}