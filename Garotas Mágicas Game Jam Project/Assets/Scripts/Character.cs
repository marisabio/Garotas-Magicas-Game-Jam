using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character")]

public class Character : ScriptableObject
{
    public int hp;
    public int mp;
    public Stats stats;
    public List<Skill> skills;

    public struct Stats 
    {
        public int evasion;
    }
}
