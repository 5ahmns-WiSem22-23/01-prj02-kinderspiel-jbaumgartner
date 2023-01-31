using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    public void PressStart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
