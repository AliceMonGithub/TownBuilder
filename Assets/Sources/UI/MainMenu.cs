using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Sources.UI
{
    public class MainMenu : MonoBehaviour
    {
        public void SetBuildingMultiply(int multiply)
        {
            PlayerPrefs.SetInt("Build", multiply);
        }

        public void SetMoneyMultiply(int multiply)
        {
            PlayerPrefs.SetInt("Money", multiply);
        }

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}