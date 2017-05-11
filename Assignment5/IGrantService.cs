using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGrantService" in both code and config file together.
[ServiceContract]
public interface IGrantService
{
    [OperationContract]
    int Login(string user, string password);

    [OperationContract]
    bool RegisterPerson(Person p);

    [OperationContract]
    List<GrantRequest> GetGrant();

    [OperationContract]
    List<GrantRequest> GetGrantsByPerson(string personName);
}

[DataContract]
public class GrantInfo
{
    [DataMember]
    public string GrantRequestKey { get; set; }

    [DataMember]
    public string GrantRequestDate { get; set; }

    [DataMember]
    public string PersonKey { get; set; }

    [DataMember]
    public string GrantTypeKey { get; set; }

    [DataMember]
    public string GrantRequestExplanation { get; set; }

    [DataMember]
    public string GrantRequestAmount { get; set; }

    [DataMember]
    public List<Person> GrantPerson { get; set; }
}