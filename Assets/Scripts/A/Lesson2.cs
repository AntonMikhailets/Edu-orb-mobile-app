using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json;

public class Lesson2 : MonoBehaviour
{
    public string Login;
    public string Password;
    public string url;
   // public Text Text;
    public SubdivisionForm SubdivisionForm;

    private void Start()
    {
        HttpGetByWebRequ(url, Login, Password);
    }

    
    public string HttpGetByWebRequ(string url, string username, string password)
    {
    //For Basic Authentication
    string authInfo = username + ":" + password;
    authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));

    //For Proxy
    WebProxy proxy = new WebProxy("http://193.169.35.211", true);

    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    request.Method = "GET";
    request.Accept = "application/json; charset=utf-8";
    request.Proxy = proxy;

    request.Headers["Authorization"] = "Basic " + authInfo;

    var response = (HttpWebResponse)request.GetResponse();

    //var weather = JsonConvert.DeserializeObject<SubdivisionResponce>(request)

    //var allGames = JsonUtility.FromJson<SubdivisionResponce>(request.downloadHandler.text);

    string strResponse = "";
    using (var sr = new StreamReader(response.GetResponseStream()))
    {
        strResponse= sr.ReadToEnd();

    }

    var weather = JsonConvert.DeserializeObject<SubdivisionResponce>(strResponse);

    Parse(weather);    

    return strResponse;


}

    private void Parse(SubdivisionResponce _SubdivisionResponce)
    {

        int oktmoObjectsVal  = _SubdivisionResponce._embedded.oktmoObjects.Count;

        for(int i = 0; i < oktmoObjectsVal;i++)
        {
            SubdivisionForm clone = Instantiate(SubdivisionForm, transform.position, transform.rotation);
             

            clone.transform.SetParent(GameObject.Find("Canvas/FirstStepButtons").transform);

             //GameObject.Find("Canvas").transform;
            clone.SetParameters(_SubdivisionResponce._embedded.oktmoObjects[i].id, _SubdivisionResponce._embedded.oktmoObjects[i].name, _SubdivisionResponce._embedded.oktmoObjects[i].oktmoCode);
            
        }
    }


}
