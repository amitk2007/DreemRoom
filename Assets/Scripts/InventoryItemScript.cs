using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItemScript : MonoBehaviour, IPointerClickHandler
{
    public static ScriptableItem chosenObject = null;
    public static int chosenInt = -1;
    public void OnPointerClick(PointerEventData eventData)
    {
        print("clicked on inventory");
        if (chosenInt != -1)
            (this.transform.parent.parent.GetChild(chosenInt).GetChild(0).GetComponent("Shadow") as MonoBehaviour).enabled = false;
        chosenInt = -1;
        chosenObject = null;
        //print(this.transform.parent.name);
        if (this.GetComponent<Image>().color == Color.white)
        {
            (this.GetComponent("Shadow") as MonoBehaviour).enabled = true;
            chosenInt = this.transform.parent.GetSiblingIndex();
            chosenObject = InventoryScript.inventoryItems[chosenInt];
        }
    }

    public static void UseSelected()
    {
        InventoryScript.RemoveItem(chosenInt);
    }

    // Start is called before the first frame update
    void Start()
    {

    }
}
