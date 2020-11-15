using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;

public class ThirdStep : MonoBehaviour
{
    public RequestForm RequestForm;
    public Unitidrequest_3_Form Unitidrequest_3_Form;
    private string strResponse;
    public Text Text;
    public string str;
    public string[] lines;
    public List<string> IDAndName;

    private void Start()
    {
    	SubdivisionForm.AStep_2 += SetFunction;
    	SetFunction("http://193.169.35.211/api/v1/dto/services/getServices?unitId=1&preRecord=true");
    }
    
    public void SetFunction(string url)
    {
    	strResponse = RequestForm.HttpGetByWebRequ(url);

    	str = strResponse;

    	//str = str.Replace("\"name\":\"Полное наименование тестового офиса\"", "");
    	
    	lines = str.Split(new char[] { ',' });

    	foreach (string s in lines)
        {
            if (s.Contains("\"id\":") || s.Contains("\"description\":"))
            {
                IDAndName.Add(s);
            }                
        }

        for(int i = 0; i < IDAndName.Count; i++)
        {

            if ((IDAndName[i].Contains("\"name\":\"Полное наименование тестового офиса\"")) || (IDAndName[i].Contains("Льготные категории граждан")) 
            	|| (IDAndName[i].Contains("\"unit\"")) || (IDAndName[i].Contains("\"faceTypes\"")) )
            {
            	IDAndName[i] = "";
            }

            IDAndName[i] = IDAndName[i].Replace("\"id\":", "");
            IDAndName[i] = IDAndName[i].Replace("\"description\":", "");
            IDAndName[i] = IDAndName[i].Replace("\"children\":[{", "");
            IDAndName[i] = IDAndName[i].Replace("\"childrenGroups\":[{", "");
            IDAndName[i] = IDAndName[i].Replace("{", "");
            IDAndName[i] = IDAndName[i].Replace("[", "");
            IDAndName[i] = IDAndName[i].Replace("\"", "");
            IDAndName[i] = IDAndName[i].Replace("null", "");
            //IDAndName[i] = IDAndName[i].Replace(", "");                    
        }

         IDAndName[0] = "";


        List<string> newList = new List<string>();

        foreach (string s in IDAndName)
        {
            if (s != "")
            {
               newList.Add(s);
            }                
        }

        IDAndName = newList;






    	//var myJson = JsonConvert.DeserializeObject<Unitidrequest_3>(strResponse);

    	//Parse(myJson);    
    }

    private void Parse(Unitidrequest_3 obj)
    {



    	Text.text += obj.zero.name + "\n";
    	Text.text += obj.zero.children.Count + "\n";
    	Text.text += obj.zero.childrenGroups.Count + "\n";
    	Text.text += obj.zero.faceTypes.Count + "\n";


    	/*val = obj._embedded.units.Count;


        int oktmoObjectsVal  = obj._embedded.units.Count;

        for(int i = 0; i < oktmoObjectsVal;i++)
        {

    		Unitidrequest_3_Form clone = Instantiate(Unitidrequest_3_Form, transform.position, transform.rotation);
             
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
        }*/
    }
}
