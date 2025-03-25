using UnityEngine;

public abstract class Item : ScriptableObject
{
    public bool isUsable;
    public abstract void Use();
    
}