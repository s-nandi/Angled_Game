using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver
{
    public static void Run()
    {
        Debug.Log("Game over!");
        // TODO: Add a 'Game Over' scene instead of terminating the applicaiton
        UnityEditor.EditorApplication.isPlaying = false; // Needed to end the game if running in-editor
        Application.Quit();
    }
}
