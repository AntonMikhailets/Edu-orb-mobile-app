using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_3
{
    public int id { get; set; }
    public string description { get; set; }
    public string main { get; set; }
    public string companyId { get; set; }
    public string terminalFooter { get; set; }
    public string textScrolling { get; set; }
    public string code { get; set; }
    public string name { get; set; }
    public string shortName { get; set; }
    public string tabloHeader { get; set; }
    public string districtId { get; set; }
    public string legalAddress { get; set; }
    public string legalAddressDescription { get; set; }
    public string phone { get; set; }
    public string fax { get; set; }
    public string email { get; set; }
    public string workingHours { get; set; }
    public double longitude { get; set; }
    public double latitude { get; set; }
    public string notifierCode { get; set; }
    public string terminalHeader { get; set; }
    public string information { get; set; }
    public string displayHeader { get; set; }
    public string passphrase { get; set; }
    public int sperId { get; set; }
    public string mdmFilialGuid { get; set; }
    public string parentUnit { get; set; }
    public string mkguId { get; set; }
    public string mkguOkato { get; set; }
    public string externalId { get; set; }
    public List <string > propertyLinkUnits { get; set; }
    public List <string > properties { get; set; }
    public List <string > workTimes { get; set; }
    public List <string > talons { get; set; }
    public List <string > users { get; set; }
    public List <string > halls { get; set; }
    public List <string > seanses { get; set; }
    public List <string > departments { get; set; }
    public List <string > services { get; set; }
    public List <string > templates { get; set; }
    public List <string > routes { get; set; }
    public List <string > userLinkUnits { get; set; }
    public List <string > workTimeRanges { get; set; }
    public List <string > childrenUnits { get; set; }
    public List <string > scenarios { get; set; }
}

public class FaceTypesItem
{
    public int id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public string extId { get; set; }
    public string deleted { get; set; }
    public string prefix { get; set; }
    public int priority { get; set; }
}

public class Zero
{
    public int id { get; set; }
    public string serviceMain { get; set; }
    public string govAgency { get; set; }
    public string workTime { get; set; }
    public Unit_3 unit { get; set; }
    public int place { get; set; }
    public string textVisitorFio { get; set; }
    public string withReturn { get; set; }
    public string price { get; set; }
    public string timeServicePreRecord { get; set; }
    public string prefix { get; set; }
    public string preRecordDays { get; set; }
    public string code { get; set; }
    public string preRecordTodayPercent { get; set; }
    public string group { get; set; }
    public string active { get; set; }
    public string textCountService { get; set; }
    public string preRecordPercent { get; set; }
    public int priority { get; set; }
    public string qualityRating { get; set; }
    public string image { get; set; }
    public string timeService { get; set; }
    public string information { get; set; }
    public string description { get; set; }
    public string visitorFio { get; set; }
    public string name { get; set; }
    public string returnPriority { get; set; }
    public string complex { get; set; }
    public string route { get; set; }
    public string rguServiceId { get; set; }
    public string rguProcedureId { get; set; }
    public string stopped { get; set; }
    public string maxCountService { get; set; }
    public string first { get; set; }
    public string filter { get; set; }
    public string faceTypeRequired { get; set; }
    public List <ChildrenItem > children { get; set; }
    public List <string > childrenGroups { get; set; }
    public List <string > faceTypes { get; set; }
    public string lifeSituation { get; set; }
    public string picUrl { get; set; }
}

public class ChildrenItem
{
    public int id { get; set; }
    public string serviceMain { get; set; }
    public string govAgency { get; set; }
    public string workTime { get; set; }
    public Unit_3 unit { get; set; }
    public int place { get; set; }
    public string textVisitorFio { get; set; }
    public string withReturn { get; set; }
    public string price { get; set; }
    public int timeServicePreRecord { get; set; }
    public string prefix { get; set; }
    public string preRecordDays { get; set; }
    public string code { get; set; }
    public string preRecordTodayPercent { get; set; }
    public string group { get; set; }
    public string active { get; set; }
    public string textCountService { get; set; }
    public int preRecordPercent { get; set; }
    public int priority { get; set; }
    public string qualityRating { get; set; }
    public string image { get; set; }
    public int timeService { get; set; }
    public string information { get; set; }
    public string description { get; set; }
    public string visitorFio { get; set; }
    public string name { get; set; }
    public string returnPriority { get; set; }
    public string complex { get; set; }
    public string route { get; set; }
    public string rguServiceId { get; set; }
    public string rguProcedureId { get; set; }
    public string stopped { get; set; }
    public string maxCountService { get; set; }
    public string first { get; set; }
    public string filter { get; set; }
    public string faceTypeRequired { get; set; }
    public List <string > children { get; set; }
    public List <string > childrenGroups { get; set; }
    public List <FaceTypesItem > faceTypes { get; set; }
    public string lifeSituation { get; set; }
    public string picUrl { get; set; }
}

public class Unitidrequest_3
{
    public Zero zero { get; set; }
}
