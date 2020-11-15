using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubdivisionForm : MonoBehaviour
{
    public int id;
    public string name;
    public string oktmoCode;
    public string url;
    public Text Text;

    public delegate void AStep(string url);
    public static event AStep AStep_2;


    public void SetParameters(int _id, string _name, string _oktmpCode)
    {
    	id = _id;
    	name = _name;
    	oktmoCode = _oktmpCode;
    	url = url.Replace("%oktmoID%", id.ToString());
        Text.text = name;
    }

    public void OnClick()
    {
        //GameObject.Find("Canvas/SecondStep").GetComponent<SecondStep>().SetFunction(url);
        AStep_2(url);
    }
}
