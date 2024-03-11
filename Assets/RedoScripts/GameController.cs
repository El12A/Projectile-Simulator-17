using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class GameController : MonoBehaviour
    {
        // This is the class which almost all classes in my project inherit from.
        // it contains references to some scripts that are used commonly inside of other classes.
        public Projectile projectile;
        public CameraController cameraController;
        public SceneController sceneController;

        // this class contains this simple Rounding function as it is used in quite a few scripts and it is very generic function that can be used in any class
        public string RoundToSF(float number, int sigFigs)
        {
            string numberString = number.ToString();
            if (number > float.NegativeInfinity && number < float.PositiveInfinity)
            {
                // Check if the number is negative and contains a decimal point
                if (number < 0 && numberString.Contains('.'))
                {
                    // Return the first five characters including the minus sign
                    return numberString.Substring(0, Mathf.Min(numberString.Length, (sigFigs + 2)));
                }
                // Check if the number contains a decimal point or a negative sign
                else if (numberString.Contains('.') || number < 0)
                {
                    // Return the first four characters
                    return numberString.Substring(0, Mathf.Min(numberString.Length, (sigFigs + 1)));
                }
                else
                {
                    // Return the first three characters
                    return numberString.Substring(0, Mathf.Min(numberString.Length, sigFigs));
                }

            }
            return numberString;
        }
    }
}
