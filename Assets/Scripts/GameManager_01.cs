using UnityEngine;
using System.Collections;

public class GameManager_01 : MonoBehaviour {

    public enum PlayState { ArmySetup, Game, End};
    public enum GameState { MapMode, UnitMode}

    public PlayState ps;       //Overall state
    public GameState gs;       //States within Game

    public GameObject selectedUnit;


    void Start()
    {
        ps = PlayState.ArmySetup;
        gs = GameState.MapMode;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (gs == GameState.UnitMode)
            {
                gs = GameState.MapMode;
            }
            if (gs == GameState.MapMode)
            {
                gs = GameState.UnitMode;
            }
        }
    }
}
