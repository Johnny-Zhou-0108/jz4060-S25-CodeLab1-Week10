using UnityEngine;

public class NYUStudent : NYUPerson
{
    public int gradYear;

    public NYUStudent()
    {
    }

    public NYUStudent(string netId, string name, 
        long nNumber, float age, int gradYear) : base(netId, name, nNumber, age)
    {
        this.gradYear = gradYear;
    }
    
    public override string GetRecord()
    {
        string result = base.GetRecord();
        result += "Grad Year: " + gradYear + "\n";
        return result;
    }
}
