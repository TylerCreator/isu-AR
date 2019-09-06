using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TakeScreenshot : MonoBehaviour {

	public void TakePhoto(){
		StartCoroutine(CaptureScreenshot());
	}
	public IEnumerator CaptureScreenshot(){
		yield return new WaitForEndOfFrame();
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string path = Application.persistentDataPath + "/" + timeStamp  + ".png";

		Texture2D screenImage = new Texture2D(Screen.width, Screen.height);
		//Get Image from screen
		screenImage.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		screenImage.Apply();
		//Convert to png
		byte[] imageBytes = screenImage.EncodeToPNG();

		//Save image to file
		System.IO.File.WriteAllBytes(path, imageBytes);

	}
}