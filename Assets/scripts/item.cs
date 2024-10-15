using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Tilemaps;

//nie za bardzo wiem co tu siê dzieje ale wiem ¿e jest to scrypt do definiowania atrybutów itemów
[CreateAssetMenu(menuName = "scriptable object/item")]
public class Item : ScriptableObject
{
    [Header("only gameplay")]
    public TileBase tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("only UI")]
    public bool stackable = true;

    [Header("both")]
    public Sprite image;

    public enum ItemType
    {
        BuldingBlock,
        tool
    }
    //clasa do okreœlania rodzaju przedmiotu

    public enum ActionType
    {
        Dig,
        Mine
    }
    //klasa do okreœlania rodzaju czynnoœci
}
