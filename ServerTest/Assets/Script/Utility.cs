using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility : MonoBehaviour
{
    public static bool IsTestButton()
    {
        return Input.GetKeyDown(KeyCode.Return);
    }
}
