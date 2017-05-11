using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GrantService" in code, svc and config file together.
public class GrantService : IGrantService
{
    Community_AssistEntities db = new Community_AssistEntities();

    public List<GrantRequest> GetGrant()
    {
        var gs = from b in db.GrantRequests
                     select b;

        List<GrantRequest> grants = new List<GrantRequest>();
        foreach (var g in gs)
        {
            GrantRequest grant1 = new GrantRequest();
            grant1.PersonKey = g.PersonKey;
            grant1.GrantRequestDate = g.GrantRequestDate;
            grant1.GrantRequestExplanation = g.GrantRequestExplanation;
            grants.Add(grant1);
        }
        return grants;
    }


    public List<GrantRequest> GetGrantsByPerson(string personName)
    {
        var gs = from b in db.GrantRequests
                 where b.Person.PersonLastName == personName
                 select b;

        List<GrantRequest> grants = new List<GrantRequest>();
        foreach (var g in gs)
        {
            GrantRequest grant1 = new GrantRequest();
            grant1.PersonKey = g.PersonKey;
            grant1.GrantRequestDate = g.GrantRequestDate;
            grant1.GrantRequestExplanation = g.GrantRequestExplanation;
            grants.Add(grant1);
        }
        return grants;
    }

    public int Login(string user, string password)
    {
        int key = 0;
        int result = db.usp_Login(user, password);
        if(result != -1)
        {
            var userKey = (from k in db.People
                           where k.PersonEmail.Equals(user)
                           select k.PersonKey).FirstOrDefault();
        }
        return key;
    }

    public bool RegisterPerson(Person p)
    {
        bool result = true;
        int pers = db.usp_Register(p.PersonLastName, p.PersonFirstName, p.PersonEmail,
            p.PersonPassWord);

        return result;
    }
}
