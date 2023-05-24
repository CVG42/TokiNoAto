using System.Collections;
using UnityEngine;

public class ButtonSequence : MonoBehaviour
{
    public static string correctCode = "1234";
    public static string playerCode = "";
    public static bool isShooting;
    public static int totalDigits = 0;
    public PlayerController player;

    void Start()
    {
        //isShooting = true;
        player.speed = 0;
    }

    void Update()
    {
        if(totalDigits == 4)
        {
            if(playerCode==correctCode)
            {
                //Debug.Log("Correct");
                isShooting = false;
                playerCode = "";
                totalDigits = 0;
                player.speed = 3;
            }
            else
            {
                playerCode = "";
                totalDigits = 0;
                //Debug.Log("Try again");
            }
        }
    }

    void OnMouseUp()
    {
        playerCode += gameObject.name;
        totalDigits += 1;
        //Debug.Log(playerCode);
    }
}
