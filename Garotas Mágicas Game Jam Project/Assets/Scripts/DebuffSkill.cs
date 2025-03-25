using UnityEngine;

[CreateAssetMenu(menuName = "Skill/Debuff")]

public class DebuffSkill : Skill
{
    public StatsEnum statsToDebuff;
    public int durationInTurns;
    public int amount;
    public bool needsOriginAlive;

    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}