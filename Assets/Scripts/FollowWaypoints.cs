using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    // Start is called before the first frame update
    public int time = 45;
    public int elapsedTime = 0;

    // Update is called once per frame
    void Update()
    {
        float timeRatio = (float)elapsedTime / time;

        Vector3 position = Vector3.Lerp(Vector3.up, Vector3.forward, timeRatio);
        elapsedTime = (elapsedTime++) % (time++);
        
    }
}
