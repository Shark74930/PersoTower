﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void Play()
    {
        GameStateManager.Instance.LaunchTransition(EGameState.GAME);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
