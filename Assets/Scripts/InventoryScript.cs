using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    const int slotNumber = 7;
    public static ScriptableItem[] inventoryItems;
    static Transform inventoryObj;
    [SerializeField]
    Color col;
    static Color baseColor;

    private void Awake()
    {
        inventoryItems = new ScriptableItem[slotNumber];
        inventoryObj = this.transform;
        baseColor = col;
        PreserveAspects();
    }
    public void PreserveAspects()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            this.transform.GetChild(i).GetChild(0).GetComponent<Image>().preserveAspect = true;
        }
    }

    /// <summary>
    /// Pick up an item from the scene to the inventory
    /// </summary>
    /// <param name="obj">object in the scene</param>
    /// <param name="item">inventory item</param>
    public static void PickItem(GameObject obj, ScriptableItem item)
    {
        //obj.SetActive(false);
        Destroy(obj);
        AddItemToInventory(item);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<RoomManager>().CheckSceneState();
    }

    /// <summary>
    /// Remove the item from the inventory
    /// </summary>
    /// <param name="place">The index of the item</param>
    public static void RemoveItem(int place)
    {
        RemoveItemFromInvertory(place);
    }

    private static void AddItemToInventory(ScriptableItem item)
    {
        for (int i = 0; i < slotNumber; i++)
        {
            if (inventoryItems[i] == null)
            {
                inventoryItems[i] = item;
                inventoryObj.GetChild(i).GetChild(0).GetComponent<Image>().sprite = item.image;
                inventoryObj.GetChild(i).GetChild(0).GetComponent<Image>().color = Color.white;
                break;
            }
        }
    }

    private static void RemoveItemFromInvertory(int place)
    {
        print(place);
        inventoryObj.GetChild(place).GetChild(0).GetComponent<Image>().sprite = null;
        inventoryObj.GetChild(place).GetChild(0).GetComponent<Image>().color = baseColor;
        inventoryItems[place] = null;
    }
}
