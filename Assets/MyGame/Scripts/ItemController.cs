using UnityEngine;

public class ItemController : MonoBehaviour
{
    public MainSceneManager gm;
    public MainSceneManager.Item item;


    // In der OnCollisionEnter2D-Methode wird ein Switch-Statement verwendet, um zu überprüfen, welches Item kollidiert ist.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (item)
        {
            // Wenn das Item Boot ist, wird überprüft, ob das kollidierende Objekt ein Fisch ist. 
            case MainSceneManager.Item.Boat:

                //Wenn ja, wird die CheckForWin-Methode aufgerufen und das kollidierende Objekt zerstört.
                if (collision.gameObject.CompareTag("Border"))
                {
                    gm.GameOver(MainSceneManager.Item.Boat);
                }

                if (collision.gameObject.CompareTag("Fish"))
                {
                    MainSceneManager.fishCount--;

                    if(MainSceneManager.fishCount <= 0)
                    {
                        gm.GameOver(MainSceneManager.Item.Boat);
                    }

                    Destroy(collision.gameObject);
                }
                break;

            // Wenn das Item Fisch ist, wird überprüft, ob das kollidierende Objekt die Grenze ist. Wenn ja, wird die GameOver-Methode aufgerufen.
            case MainSceneManager.Item.Fish:

                if (collision.gameObject.CompareTag("Border") )
                {
                    MainSceneManager.freeFish++;
                    MainSceneManager.fishCount--;

                    if (MainSceneManager.freeFish == 4)
                    {
                        gm.GameOver(MainSceneManager.Item.Fish);
                    }

                    Destroy(gameObject);
                }
                break;
        }
    }
}
