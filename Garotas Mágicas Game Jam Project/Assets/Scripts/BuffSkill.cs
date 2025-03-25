using UnityEngine;

[CreateAssetMenu(menuName = "Skill/Buff")]

public class BuffSkill : Skill
{
    public int amount;
    public int durationInTurns;
    public StatsEnum statsToBuff;

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}