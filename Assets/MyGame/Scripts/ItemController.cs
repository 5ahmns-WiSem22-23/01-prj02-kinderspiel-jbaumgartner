using UnityEngine;

public class ItemController : MonoBehaviour
{
    public MainSceneManager gm;
    public MainSceneManager.Item item;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (item)
        {
            case MainSceneManager.Item.Boat:

                if (collision.gameObject.CompareTag("Fish"))
                {
                    gm.CheckForWin();
                }
                Destroy(collision.gameObject);
                break;

            case MainSceneManager.Item.Fish:
                if (collision.gameObject.CompareTag("Border"))
                {
                    gm.GameOver(MainSceneManager.Item.Fish);
                }
                break;
        }
    }
}
