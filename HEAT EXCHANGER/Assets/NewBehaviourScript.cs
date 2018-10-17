using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Networking;
using System.Text.RegularExpressions;
using System;
using UnityEngine.UI;

[System.Serializable]

public class NewBehaviourScript : MonoBehaviour {
public Text microTemperatureText;
public Button b1;
public Button b2;
public string microTemperatureVal;
public Text microTemperatureText1;
public string microTemperatureVal1;
public Text flow1;
public string flowv1;
public Text flow2;
public string flowv2;
    void Update()
    {
        StartCoroutine(GetText());
microTemperatureText.text = microTemperatureVal.ToString ();
checkTemperature1();
microTemperatureText1.text = microTemperatureVal1.ToString ();
checkTemperature2();
flow1.text = flowv1.ToString ();
flow2.text = flowv2.ToString ();
}
    IEnumerator GetText()
    {


    string url = "https://api.thinger.io/v2/users/abhey/devices/NodeMCU/Flow";
    string authorization="Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkZXYiOiJOb2RlTUNVIiwiaWF0IjoxNTM4MjA5NDUzLCJqdGkiOiI1YmFmMzZhZDg2MTA3NGIyMmUwYTM4NjMiLCJ1c3IiOiJhYmhleSJ9.5jTDcXyw-JKn5FCE5-K8qwvEFfH2uOW65coWxMwxS6E";    
UnityWebRequest www = UnityWebRequest.Get(url);
        {
            www.SetRequestHeader("AUTHORIZATION", authorization);
            yield return www.SendWebRequest();
            
            
            
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {

                // Show results as text
             Char delimiter = '"';
             string result = www.downloadHandler.text;
 //Debug.Log (result);
             String[] substrings = result.Split(delimiter);
                if (substrings[8].Contains (":")) 
                {   
                    String[] Substrings1 = substrings[8].Split (':');
                    if(Substrings1[1].Contains (":"))
                        {
                        String[] s3 = Substrings1[1].Split (':'); 
                        Substrings1[1]=s3[1];  
                        }
                        if(Substrings1[1].Contains ("}"))
                        {
                        String[] s1 = Substrings1[1].Split ('}'); 
                        Substrings1[1]=s1[0];  
                        }
                     if(Substrings1[1].Contains (","))
                        {
                        String[] s2 = Substrings1[1].Split (','); 
                        Substrings1[1]=s2[0];  
                        }
                        Debug.Log (Substrings1[1]);
                       microTemperatureVal=Substrings1[1];
                     //    microTemperatureVal1=Substrings1[1];
            }
            if (substrings[6].Contains (":")) 
                {   
                    String[] Substrings1 = substrings[10].Split (':');
                    if(Substrings1[1].Contains (":"))
                        {
                        String[] s3 = Substrings1[10].Split (':'); 
                        Substrings1[1]=s3[1];  
                        }
                        if(Substrings1[1].Contains ("}"))
                        {
                        String[] s1 = Substrings1[1].Split ('}'); 
                        Substrings1[1]=s1[0];  
                        }
                     if(Substrings1[1].Contains (","))
                        {
                        String[] s2 = Substrings1[1].Split (','); 
                        Substrings1[1]=s2[0];  
                        }
                     //   Debug.Log (Substrings1[1]);
                    //  microTemperatureVal=Substrings1[1];
                         microTemperatureVal1=Substrings1[1];
            }
                 if (substrings[4].Contains (":")) 
                {   
                    String[] Substrings1 = substrings[4].Split (':');
                    if(Substrings1[1].Contains (":"))
                        {
                        String[] s3 = Substrings1[1].Split (':'); 
                        Substrings1[1]=s3[1];  
                        }
                        if(Substrings1[1].Contains ("}"))
                        {
                        String[] s1 = Substrings1[1].Split ('}'); 
                        Substrings1[1]=s1[0];  
                        }
                     if(Substrings1[1].Contains (","))
                        {
                        String[] s2 = Substrings1[1].Split (','); 
                        Substrings1[1]=s2[0];  
                        }
                     //   Debug.Log (Substrings1[1]);
                      flowv1=Substrings1[1];
                      
            }
 if (substrings[6].Contains (":")) 
                {   
                    String[] Substrings1 = substrings[6].Split (':');
                    if(Substrings1[1].Contains (":"))
                        {
                        String[] s3 = Substrings1[1].Split (':'); 
                        Substrings1[1]=s3[1];  
                        }
                        if(Substrings1[1].Contains ("}"))
                        {
                        String[] s1 = Substrings1[1].Split ('}'); 
                        Substrings1[1]=s1[0];  
                        }
                     if(Substrings1[1].Contains (","))
                        {
                        String[] s2 = Substrings1[1].Split (','); 
                        Substrings1[1]=s2[0];  
                        }
                     //   Debug.Log (Substrings1[1]);
                      flowv2=Substrings1[1];
                      
            }

            }
        }
}
private void checkTemperature1() {
		int index = 0;
		if (microTemperatureVal.Contains ("32.")) // Green Color - temperature is ok
			greenButtonColor (index);// (Buttons[0]);
		if (microTemperatureVal.Contains ("148.")) // Red Color - temperature is too Hot
			orangeButtonColor(index);
		if (microTemperatureVal.Contains ("113.")||microTemperatureVal.Contains ("114.")||microTemperatureVal.Contains ("116.")) // Blue Color - temperature is too Cold
			blueButtonColor (index);
	}
private void checkTemperature2() {
		int index = 1;
		if (microTemperatureVal1.Contains ("32.")||microTemperatureVal1.Contains ("33.")) // Green Color - temperature is ok
			greenButtonColor2 (index);// (Buttons[0]);
		if (microTemperatureVal1.Contains ("150.")) // Red Color - temperature is too Hot
			orangeButtonColor2(index);
		if (microTemperatureVal1.Contains ("112.")||microTemperatureVal1.Contains ("115.")||microTemperatureVal1.Contains ("116.")) // Blue Color - temperature is too Cold
			blueButtonColor2 (index);
	}
private void greenButtonColor (int i) { 
		//Debug.Log ("Green");
		Color greenColor = new Color (0.00f, 0.94f, 0.12f, 1.0f);
	//	Button b = Buttons[i].GetComponent<Button>(); 
		ColorBlock cb = b1.colors;
		cb.normalColor = greenColor;
		b1.colors = cb;
		//EffectColor.GetComponent<LineRenderer> ().material.SetColor ("_TintColor",greenColor);
	}
	private void orangeButtonColor (int i) {
		//Debug.Log ("Orange"); // yellow
		Color redColor = new Color (1.0f, 0.48f, 0.16f, 1.0f);
		//Button b = Buttons[i].GetComponent<Button>(); 
		ColorBlock cb = b1.colors;
		cb.normalColor = redColor;
		b1.colors = cb;
	}

	private void blueButtonColor (int i) {
		//Debug.Log ("yellow changed");
		Color blueColor = new Color (1.0f, 0.92f, 0.016f, 1.0f);
		//Button b = Buttons[i].GetComponent<Button> (); 
		ColorBlock cb = b1.colors;
		cb.normalColor = blueColor;
		b1.colors = cb;
	}
private void greenButtonColor2 (int i) { 
		//Debug.Log ("Green");
		Color greenColor = new Color (0.00f, 0.94f, 0.12f, 1.0f);
	//	Button b = Buttons[i].GetComponent<Button>(); 
		ColorBlock cb = b2.colors;
		cb.normalColor = greenColor;
		b2.colors = cb;
		//EffectColor.GetComponent<LineRenderer> ().material.SetColor ("_TintColor",greenColor);
	}
	private void orangeButtonColor2 (int i) {
		//Debug.Log ("Orange"); // yellow
		Color redColor = new Color (1.0f, 0.48f, 0.16f, 1.0f);
		//Button b = Buttons[i].GetComponent<Button>(); 
		ColorBlock cb = b2.colors;
		cb.normalColor = redColor;
		b2.colors = cb;
	}

	private void blueButtonColor2 (int i) {
		//Debug.Log ("yellow changed");
		Color blueColor = new Color (1.0f, 0.92f, 0.016f, 1.0f);
		//Button b = Buttons[i].GetComponent<Button> (); 
		ColorBlock cb = b2.colors;
		cb.normalColor = blueColor;
		b2.colors = cb;
	}
}