using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Tilemaps;

//nie za bardzo wiem co tu si� dzieje ale wiem �e jest to scrypt do definiowania atrybut�w item�w
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
    //clasa do okre�lania rodzaju przedmiotu

    public enum ActionType
    {
        Dig,
        Mine
    }
    //klasa do okre�lania rodzaju czynno�ci
}
