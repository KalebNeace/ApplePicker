using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Update is called once per frame
       void Update()
    {
        if (transform.position.y < bottomY){
            Destroy(this.gameObject);
        }
        ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
        //ToDo: 
        //This seems to be called from wrong place. 
        //Make sure that this is called on appropriate time and not every frame.
        //I believe this should be inside the if function {}
        apScript.AppleMissed();
    }

}
