using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class SecondStep : MonoBehaviour
{
    public RequestForm RequestForm;
    public Request_for_OKTMO_units_2_Form Request_for_OKTMO_units_2_Form;
    private string strResponse;
    public int val;

    private void Start()
    {
    	SubdivisionForm.AStep_2 += SetFunction;
    }
    
    public void SetFunction(string url)
    {
    	strResponse = RequestForm.HttpGetByWebRequ(url);

    	var myJson = JsonConvert.DeserializeObject<Request_for_OKTMO_units_2>(strResponse);

    	Parse(myJson);    
    }

    private void Parse(Request_for_OKTMO_units_2 obj)
    {
    	val = obj._embedded.units.Count;


        int oktmoObjectsVal  = obj._embedded.units.Count;

        for(int i = 0; i < oktmoObjectsVal;i++)
        {

    		Request_for_OKTMO_units_2_Form clone = Instantiate(Request_for_OKTMO_units_2_Form, transform.position, transform.rotation);
             
            clone.transform.SetParent(gameObject.transform);
         	//GameObject.Find("Canvas").transform;
            clone.SetForm(
            	obj._embedded.units[i].id,
             	obj._embedded.units[i].main,
             	obj._embedded.units[i].name,
             	obj._embedded.units[i].shortName,
             	obj._embedded.units[i].email,
             	obj._embedded.units[i].phone,
             	obj._embedded.units[i].legalAddress,
             	obj._embedded.units[i].workingHours,
             	obj._embedded.units[i].longitude,
             	obj._embedded.units[i].latitude
             );
        }
    }


}
