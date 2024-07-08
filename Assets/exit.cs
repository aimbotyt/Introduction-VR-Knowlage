using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class exit : MonoBehaviour
{
    public void Quit()
    {
        EditorApplication.isPlaying = false;
        
        Application.Quit();
        Debug.Log("Quit");

    }

}
