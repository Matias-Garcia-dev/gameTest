using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState {START, PLAYERTURN, ENEMYTURN, WON, LOST}
public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

// Referencia a el enum BattleState llamado state
    public BattleState state;
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void Update()
    {

    }
    void SetupBattle()
    {
        Instantiate(playerPrefab, playerBattleStation);
        Instantiate(enemyPrefab, enemyBattleStation);
    }
}
