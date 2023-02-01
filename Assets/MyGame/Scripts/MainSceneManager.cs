using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    // Es wird ein Enum Item erstellt, um den Gewinner zu speichern
    public enum Item
    {
        Fish,
        Boat
    }

    public static Item currentWinner;

    public int moveAmount;

    public static int freeFish;
    public static int fishCount;


    public GameObject redFish;
    public GameObject blueFish;
    public GameObject greenFish;
    public GameObject yellowFish;
    public GameObject boat;


    // In der Start() Methode wird fishCount auf 4 gesetzt.
    private void Start()
    {
        freeFish = 0;
        fishCount = 4;
    }

    // In der Update() Methode wird überprüft, ob die Leertaste gedrückt wurde und dann die RollDice() Methode aufgerufen.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
    }

    // Die MoveItem() Methode bewegt das übergebene GameObject um moveAmount
    void MoveItem(GameObject item)
    {
        item.transform.position = new Vector3(item.transform.position.x + moveAmount, item.transform.position.y, item.transform.position.z);
    }

    // Die GameOver() Methode speichert den Gewinner in currentWinner und lädt die Endscene.
    public void GameOver(Item winner)
    {
        currentWinner = winner;
        SceneManager.LoadScene("Endscene");
    }

    // Die RollDice() Methode generiert eine Zufallszahl zwischen 1 und 6 und bewegt dann das entsprechende GameObject.
    void RollDice()
    {
        int random = Random.Range(1, 7);

        switch (random){
            case 1:
                // Red
                try {
                    MoveItem(redFish);
                }
                catch
                {
                    MoveItem(boat);
                }
                break;

            case 2:
                // Blue
                try
                {
                    MoveItem(blueFish);
                }
                catch
                {
                    MoveItem(boat);
                }
                break;

            case 3:
                // Green
                try
                {
                    MoveItem(greenFish);
                }
                catch
                {
                    MoveItem(boat);
                }
                break;

            case 4:
                // Yellow
                try
                {
                    MoveItem(yellowFish);
                }
                catch
                {
                    MoveItem(boat);
                }
                break;

            case 5:
                // Boat
                MoveItem(boat);
                break;

            case 6:
                // Boat
                MoveItem(boat);
                break;
        }
    }
}
