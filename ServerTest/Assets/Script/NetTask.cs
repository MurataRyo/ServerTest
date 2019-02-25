using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetTask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Utility.IsTestButton())
        {
            Debug.Log(IsInternet());
        }
    }

    //インターネットにつながっているかどうか
    public static bool IsInternet()
    {
        //                                           繋がっていない場合↓
        return !(Application.internetReachability == NetworkReachability.NotReachable);
    }
}
