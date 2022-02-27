using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewObject", menuName = "EscapeElement", order = 1)]
public class ScriptableItem : ScriptableObject
{
    public Sprite image;
    public string objName;
    public AudioClip sound;
}
