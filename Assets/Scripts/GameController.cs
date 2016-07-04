using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	enum GameStates { Setup, GamePlay, End};

    enum PlayStates { MapState, UnitState}

    PlayStates ps;

    private int maxPlayerCount;
    private int maxEnemyCount;


    void Start()
    {
        ps = PlayStates.MapState;

    }


    void Update()
    {
        if(ps == PlayStates.MapState)
        {
            MapControls();
        }
    }

    void MapControls()
    {

    }

}
