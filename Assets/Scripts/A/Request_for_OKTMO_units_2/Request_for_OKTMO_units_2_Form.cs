using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Request_for_OKTMO_units_2_Form : MonoBehaviour
{
	//public Text id;    
    //public Text main;  
    // public Text name;   
    public Text shortNameText;
 	public Text eMailText;
 	public Text phoneText;
 	public Text legalAddressText;
 	//public Text workingHours;
 	
    public int id;    
    public string main;  
    public string name;   
    public string shortName;
 	public string eMail;
 	public string phone;
 	public string legalAddress;
 	public string workingHours;
 	public double longitude;
 	public double latitude;

 	static string url = "http://193.169.35.211/api/v1/dto/services/getServices?unitId=%unitId%&preRecord=true";

 	public delegate void AStep(string url);
    public static event AStep AStep_3;

 	public void SetForm(int _id, string _main, string _name, string _shortName, string _eMail, string _phone, string _legalAddress, string _workingHours,
 		double _longitude, double _latitude)
 	{
 		id = _id;    
    	main = _main;  
    	name = _name;   
    	shortName = _shortName;
 		eMail = _eMail;
 		phone = _phone;
 		legalAddress = _legalAddress;
 		workingHours = _workingHours;
 		longitude = _longitude;
 		latitude = _latitude;

 		shortNameText.text = shortName;
 		eMailText.text = "eMail:" + eMail;
 		phoneText.text = "Телефон:" + phone;
 		legalAddressText.text = "Адрес:" + legalAddress;

 		url = url.Replace("%%unitId%", id.ToString());
 	}

 	public void OnClick()
    {
        //GameObject.Find("Canvas/SecondStep").GetComponent<SecondStep>().SetFunction(url);
        AStep_3(url);
    }

}
