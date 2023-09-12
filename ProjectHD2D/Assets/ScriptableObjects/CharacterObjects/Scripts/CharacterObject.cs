using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    Human,
    Demon
}
public class CharacterObject : ScriptableObject
{
    public GameObject prefab;
    public CharacterType type;
    [TextArea(15,20)]
    public string text;
}
