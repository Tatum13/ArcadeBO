using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        // Exit playmode upon pressing escape
        if (Input.GetKeyDown(KeyCode.Escape))
            EditorApplication.isPlaying = false; // EditorApplication.isPlaying is the boolean of whether playmode is True or False
    }
}
