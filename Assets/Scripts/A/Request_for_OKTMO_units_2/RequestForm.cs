using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.IO;

public class RequestForm : MonoBehaviour
{
    public string Login;
    public string Password;
    public string url;

    private void Start()
    {
        //HttpGetByWebRequ(url);
    }
    
    public string HttpGetByWebRequ(string url)
    {
    //For Basic Authentication
    string authInfo = Login + ":" + Password;
    authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));

    //For Proxy
    WebProxy proxy = new WebProxy("http://193.169.35.211", true);

    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    request.Method = "GET";
    request.Accept = "application/json; charset=utf-8";
    request.Proxy = proxy;

    request.Headers["Authorization"] = "Basic " + authInfo;

    var response = (HttpWebResponse)request.GetResponse();

    string strResponse = "";
    using (var sr = new StreamReader(response.GetResponseStream()))
    {
        strResponse= sr.ReadToEnd();
    }  
    return strResponse;
    }
}
