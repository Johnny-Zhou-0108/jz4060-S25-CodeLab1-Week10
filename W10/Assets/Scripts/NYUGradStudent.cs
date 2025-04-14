using UnityEngine;

public class NYUGradStudent : NYUStudent
{
    public string previousMajor;

    public NYUGradStudent()
    {
    }

    public NYUGradStudent(string netId, string name, 
        long nNumber, float age, int gradYear, string previousMajor) 
        : base(netId, name, nNumber, age, gradYear)
    {
        this.previousMajor = previousMajor;;
    }
    
    public override string GetRecord()
    {
        string result = base.GetRecord();
        result += "Previous Major: " + previousMajor + "\n";
        return result;
    }
}