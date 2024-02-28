using UnityEngine;
using System.Collections;

public class GenericSomeOtherClass : MonoBehaviour
{
    void Start()
    {
        GenericSomeClass myClass = new GenericSomeClass();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}