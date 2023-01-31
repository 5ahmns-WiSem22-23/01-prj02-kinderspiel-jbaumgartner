using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    public enum Item
    {
        Fish,
        Boat
    }

    public static Item currentWinner;

    public int moveAmount;

    public static int fishCount;

    public GameObject redFish;
    public GameObject blueFish;
    public GameObject greenFish;
    public GameObject yellowFish;
    public GameObject boat;

    private void Start()
    {
        fishCount = 4;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
    }

    void MoveItem(GameObject item)
    {
        item.transform.position = new Vector3(item.transform.position.x + moveAmount, item.transform.position.y, item.transform.position.z);
    }

    public void GameOver(Item winner)
    {
        currentWinner = winner;
        SceneManager.LoadScene("Endscene");
    }

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
                    RollDice();
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
                    RollDice();
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
                    RollDice();
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
                    RollDice();
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

    public void CheckForWin()
    {
        fishCount--;

        if (fishCount <= 0)
        {
            GameOver(Item.Boat);
        }

    }
}
