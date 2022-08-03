using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cw3 : MonoBehaviour
{
    string heroName = "Hero";
    int heroPower = 45;
    string villainName = "Villain";
    int villainPower = 40;
    float playerSpeed = 1f;
    float playerSpeed2 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villainPower)
        {
            print("The " + heroName + " is stronger");
        }
        else if (heroPower == villainPower)
        {
            print("They are equal in power");
        }
        else
        {
            print("The " + villainName + " is stronger");
        }

        print(playerSpeed2);
        SetSpeed(2.5f);
        print(playerSpeed2);

        CompareSpeed();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetSpeed(float speed)
    {
        playerSpeed2 = speed;
    }

    void CompareSpeed()
    {
        if (playerSpeed > playerSpeed2)
        {
            print(playerSpeed);
        }
        else if (playerSpeed == playerSpeed2)
        {
            print(playerSpeed + playerSpeed2 + "They are the same");
        }
        else
        {
            print(playerSpeed2);
        }
    }
}
