using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour {

	// Use this for initialization
	public void Shot()
    {
        // if (GUILayout.Button("Capture")){
            
        // }
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
        ScreenCapture.CaptureScreenshot(fileName);
    }
}
