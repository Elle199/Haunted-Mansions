using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "RPG Assets/New Character", order = 0)]
public class ScriptableObjCharacter : ScriptableObject
{
    public Texture2D PreviewImage;
    public new string name;
    public float health;
    public float armour;
    public float speed;
    public int intelligence;
    public int dexterity;
}
