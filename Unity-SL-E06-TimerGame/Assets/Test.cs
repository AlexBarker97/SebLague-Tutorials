using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    float roundStartDelayTime = 3;
    float roundStartTime;
    int waitTime;
    bool roundStarted;

    // Start is called before the first frame update
    void Start() {
        print("Press the spacebar once you think the time has passed.");
        Invoke("setNewRandomTime", roundStartDelayTime);
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted) 
        {
            InputReceived();
        }
    }

    //test

    void InputReceived()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        print("You waited for: " + playerWaitTime + " seconds. That's " + error + " seconds off. " + GenerateMessage(error));
        Invoke("setNewRandomTime", roundStartDelayTime);
    }

    string GenerateMessage(float error)
    {
        string message = "";
        if (error < .15f)
        {
            message = "Outstanding";
        }
        else
        {
            message = "I'll take it.";
        }
        return message;
    }

    void setNewRandomTime() {
        waitTime = Random.Range(3, 7);
        roundStartTime = Time.time;
        roundStarted = true;

        print(waitTime + " seconds");
    }

}
