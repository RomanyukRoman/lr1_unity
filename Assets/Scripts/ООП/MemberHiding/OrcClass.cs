using UnityEngine;
using System.Collections;

public class Orc : EnemyClass
{
    //This hides the Enemy version.
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}