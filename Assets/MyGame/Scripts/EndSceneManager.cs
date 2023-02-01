using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text status;

    // Im Start() wird der Text des Status-Textfelds auf Basis des aktuellen Gewinners gesetzt.
    private void Start()
    {
        if(MainSceneManager.currentWinner == MainSceneManager.Item.Fish)
        {
            status.text = "Die Fische haben gewonnen";
        }

        else if(MainSceneManager.currentWinner == MainSceneManager.Item.Boat)
        {
            if (MainSceneManager.freeFish > 2)
            {
                status.text = "Die Fische haben gewonnen";
            }
            else if(MainSceneManager.freeFish == 2)
            {
                status.text = "Unentschieden";
            }
            else
            {
                status.text = "Das Boot gewinnt";
            }
        }
    }

    // Die Methode PressRestart() lädt die MainScene, wenn sie aufgerufen wird.
    public void PressRestart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
