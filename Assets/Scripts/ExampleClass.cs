using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ExampleClass : MonoBehaviour
{
	public Text Text;

    public string url = "http://unity3d.com";
    IEnumerator Start()
    {
        using (WWW www = new WWW(url))
        {
            yield return www;

            if (www.responseHeaders.Count > 0)
            {
                foreach (KeyValuePair<string, string> entry in www.responseHeaders)
                {
                    //Debug.Log(entry.Value + "=" + entry.Key);
                    Text.text += ((entry.Value + "=" + entry.Key) + "\n");
                }
            }
        }
    }
}