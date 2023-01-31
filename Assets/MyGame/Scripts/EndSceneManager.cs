using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text status;

    private void Start()
    {
        status.text = MainSceneManager.currentWinner == MainSceneManager.Item.Boat ? "Das Boot hat gewonnen" :
            MainSceneManager.fishCount <= 2 ? "Unentschieden" : "Die Fische haben gewonnen";
    }

    public void PressRestart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
