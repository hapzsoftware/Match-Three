using UnityEngine;
using System.Collections;

public class GameFieldAnim : MonoBehaviour {

    private void Start()
    {
        
    }

    void EndAnimGamField()
    {
       LevelManager.THIS.gameStatus = GameState.Playing;
    }
}