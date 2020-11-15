using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Lesson : MonoBehaviour
{

	public string Login;
	public string Password;
	public string _url;

	private void Start(){
		createRequest( );

		//StartCoroutine(GetRequest(_url));
	}

	UnityWebRequest createRequest( )
	{
		UnityWebRequest req = UnityWebRequest.Get(_url);

		if (req.isNetworkError || req.isHttpError)
		{
			Debug.LogError(req.error);
		}else
		{
			Debug.Log(req.downloadHandler.text);
		}

		// could also use "US-ASCII" or "ISO-8859-1" encoding
		string encoding = "UTF-8"; 
		string base64 = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding(encoding).GetBytes(Login + ":" + Password));

		req.SetRequestHeader("Authorization", "Basic " + base64);
		
		Debug.Log(req.downloadHandler.text);
		
		return req;
	}

	IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest www = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return www.SendWebRequest();

            string encoding = "UTF-8"; 
			string base64 = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding(encoding).GetBytes(Login + ":" + Password));

			www.SetRequestHeader("Authorization", "Basic " + base64);
   		}
	}
}
