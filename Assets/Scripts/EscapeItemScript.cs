using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeItemScript : MonoBehaviour
{
    public ScriptableItem item;

    private void OnMouseDown()
    {
        print("clicked " + item.name);
        InventoryScript.PickItem(this.gameObject, item);
    }
}
