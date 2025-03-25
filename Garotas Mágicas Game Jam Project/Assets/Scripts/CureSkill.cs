using UnityEngine;

[CreateAssetMenu(menuName = "Skill/Cure")]

public class CureSkill : Skill
{
    public int minAmount;
    public int maxAmount;
    public bool isAOE;

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}