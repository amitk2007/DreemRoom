using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeElementScript : MonoBehaviour
{
    public ScriptableItem opener;
    public Sprite opened;
    public GameObject prize;

    private void Awake()
    {
        if (prize != null)
        {
            prize.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        if (opener == null)
        {
            OpenElement();
            CheckEndGame();
        }
        else if (InventoryItemScript.chosenObject == opener)
        {
            OpenElement();
            InventoryItemScript.UseSelected();
            CheckEndGame();
        }
    }
    public void OpenElement()
    {
        this.GetComponent<SpriteRenderer>().sprite = opened;
        // TODO create a list \ map of all tags
        this.gameObject.tag = "Open";
        if (prize != null)
        {
            prize.SetActive(true);
            //Instantiate<GameObject>(prize, this.gameObject.transform.position, Quaternion.identity);
        }
        print("open");
    }

    private void CheckEndGame()
    {
        if (GameObject.FindGameObjectsWithTag("Close").Length == 0)
        {
            print("the game has ended!");
        }
    }
}
