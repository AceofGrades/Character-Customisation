using UnityEngine;
using System.Collections;
//this script can be found in the Component section under the option Intro PRG/Character Movement
//This script requires the component Character controller to be attached to the Game Object
public class Movement : MonoBehaviour 
{
    #region Extra Study
    //Input Manager(https://docs.unity3d.com/Manual/class-InputManager.html)
    //Input(https://docs.unity3d.com/ScriptReference/Input.html)
    //CharacterController allows you to move the character kinda like Rigidbody (https://docs.unity3d.com/ScriptReference/
    #endregion
    #region Variables
    public static bool canMove;
    [Header("Character")]
    //vector3 called moveDir //we will use this to apply movement in worldspace
    public Vector3 moveDir;
    //Character controller called _charC CharacterController.html) 
    public CharacterController _charC;
    [Header("Character Speeds")]
    //public float variables jumpSpeed 8 & speed 5 & gravity 20
    public float jumpSpeed = 8;
    public float speed = 5;
    public float gravity = 20;
    #endregion
    #region Start  
    //_charc is set to the Character controller on this GameObject
    //CharacterController _charc = GetComponent<CharacterController>();
     #endregion
    #region Update
        //if our character is grounded
            //set moveDir to the inputs direction
            //moveDir's forward is changed from global z (forward) to the Game Objects local Z (forward)//allows us to move where player is facing
            //moveDir is multiplied by speed so we move at a decent pace
            //if the input button for jump is pressed then           
                //our moveDir.y is equal to our jump speed
        //regardless of if we are grounded or not the players moveDir.y is always affected by gravity timesed my time.deltaTime to normalize it
        //we then tell the character Controller that it is moving in a direction multiplied Time.deltaTime    
    #endregion
}










