using UnityEngine;

[CreateAssetMenu(menuName = "Skill/Damage")]

public class DamageSkill : Skill
{
    public int minAmount;
    public int maxAmount;
    public bool isAOE;

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}