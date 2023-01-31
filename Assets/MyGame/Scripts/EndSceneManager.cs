using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text status;

    // Im Start() wird der Text des Status-Textfelds auf Basis des aktuellen Gewinners gesetzt.
    private void Start()
    {
        status.text = MainSceneManager.currentWinner == MainSceneManager.Item.Boat ? "Das Boot hat gewonnen" :
            MainSceneManager.fishCount <= 2 ? "Unentschieden" : "Die Fische haben gewonnen";
    }

    // Die Methode PressRestart() lädt die MainScene, wenn sie aufgerufen wird.
    public void PressRestart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
