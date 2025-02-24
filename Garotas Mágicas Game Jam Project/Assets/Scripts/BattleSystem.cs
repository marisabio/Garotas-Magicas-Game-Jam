using UnityEngine;

public enum BattleState { START, ELISATURN, BEATRIZTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public BattleState state;

    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

}
