using UnityEngine;

[CreateAssetMenu(menuName = "Item/Cure")]

public class CuteItem : Item
{
    public int minAmount;
    public int maxAmount;
    public bool isAOE;

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}