using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class Self    {
        public string href { get; set; } 
    }

    public class OktmoObject2    {
        public string href { get; set; } 
        public bool templated { get; set; } 
    }

    public class OktmoLevel    {
        public string href { get; set; } 
    }

    public class GovAgencies    {
        public string href { get; set; } 
    }

    public class Timezone    {
        public string href { get; set; } 
    }

    public class OktmoObjects    {
        public string href { get; set; } 
    }

    public class Units    {
        public string href { get; set; } 
    }

    public class Links    {
        public Self self { get; set; } 
        public List<OktmoObject2> oktmoObject { get; set; } 
        public OktmoLevel oktmoLevel { get; set; } 
        public GovAgencies govAgencies { get; set; } 
        public Timezone timezone { get; set; } 
        public OktmoObjects oktmoObjects { get; set; } 
        public Units units { get; set; } 
    }

    public class OktmoObject    {
        public int id { get; set; } 
        public string name { get; set; } 
        public object kladrCode { get; set; } 
        public string description { get; set; } 
        public string oktmoCode { get; set; } 
        public Links _links { get; set; } 
    }

    public class Embedded    {
        public List<OktmoObject> oktmoObjects { get; set; } 
    }

    public class Self2    {
        public string href { get; set; } 
    }

    public class Profile    {
        public string href { get; set; } 
    }

    public class Links2    {
        public Self2 self { get; set; } 
        public Profile profile { get; set; } 
    }

    public class Page    {
        public int size { get; set; } 
        public int totalElements { get; set; } 
        public int totalPages { get; set; } 
        public int number { get; set; } 
    }

    public class SubdivisionResponce    {
        public Embedded _embedded { get; set; } 
        public Links2 _links { get; set; } 
        public Page page { get; set; } 
    }

