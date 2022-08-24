using System;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static event Action<GameState> OnBeforeStateChanged;
    public static event Action<GameState> OnAfterStateChanged;

    public GameState State { get; private set; }

    // Kick the game off with the first state
    void Start() => ChangeState(GameState.STARTING);

    public void ChangeState(GameState newState) {
        OnBeforeStateChanged?.Invoke(newState);

        State = newState;
        switch (newState) {
            case GameState.STARTING:
                HandleStarting();
                break;
            case GameState.SPAWNING:
                HandleSpawningHeroes();
                HandleSpawningEnemies();
                break;
            case GameState.BATTLE:

                break;
            case GameState.NEXTROUND:
                break;
            case GameState.RESULT:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnAfterStateChanged?.Invoke(newState);
        
        Debug.Log($"New state: {newState}");
    }

    private void HandleStarting() {
        // Do some start setup, could be environment, cinematics etc

        // Eventually call ChangeState again with your next state
        
        ChangeState(GameState.SPAWNING);
    }

    private void HandleSpawningHeroes() {
        //UnitManager.Instance.SpawnHeroes(); - utilize UnitManager to SpawnHeroes
        
    }

    private void HandleSpawningEnemies() {
        //UnitManager.Instance.SpawnEnemies(); - utilize UnitManager to SpawnEnemies
        
        
        ChangeState(GameState.BATTLE);
    }

}

[Serializable]
public enum GameState {
    STARTING = 0,
    SPAWNING = 1,
    BATTLE = 2,
    NEXTROUND = 3,
    RESULT = 4,    
}
