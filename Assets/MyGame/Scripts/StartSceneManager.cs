using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{

    // Mit dem PressStart()-Befehl wird die MainScene geladen.
    public void PressStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
