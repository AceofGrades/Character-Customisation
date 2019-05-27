using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public bool showDlg;
    public string[] dlgText;
    public Vector2 scr;
    public int index, optionsIndex;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Code version of Canvas
    private void OnGUI()
    {
        if (showDlg)
        {
            if (scr.x != Screen.width / 16 || scr.y != Screen.height / 9)
            {
                scr.x = Screen.width / 16;
                scr.y = Screen.height / 9;
            }
            // GUI element of Type Box
            // New Rectangular Position and Size
            // Pos X, Pos Y, Size X, Size Y
            // Content of box
            GUI.Box(new Rect(0, 6 * scr.y, Screen.width, 3 * scr.y), dlgText[index]);
            // Have a box that touches left edge and goes to right edge
            // Starts 2/3rds down screen and is 1/3rd in size
            // Finishes at the bottom of screen
            if (!(index + 1 >= dlgText.Length - 1 || index == optionsIndex))
            // index+1 >= dlgText.Length
            // index < dlgText.Length
            {
                if (GUI.Button(new Rect(15 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Next"))
                {
                    index++;
                }
            }
            else if (index == optionsIndex)
            {
                if (GUI.Button(new Rect(13 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Accept"))
                {
                    index++;
                }
                if (GUI.Button(new Rect(14 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Decline"))
                {
                    index = dlgText.Length - 1;
                }
            }
            else
            {
                if (GUI.Button(new Rect(15 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Bye!"))
                {
                    index = 0;
                    showDlg = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Movement.canMove = true;
                }
            }
        }
    }
}
