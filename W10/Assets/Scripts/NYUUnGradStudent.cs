using UnityEngine;

public class NYUUnGradStudent : NYUStudent
{
    public string capstoneTopic;

    public NYUUnGradStudent()
    {
    }

    public NYUUnGradStudent(string netId, string name, 
        long nNumber, float age, int gradYear, string capstoneTopic) 
        : base(netId, name, nNumber, age, gradYear)
    {
        this.capstoneTopic = capstoneTopic;;
    }
    public override string GetRecord()
    {
        string result = base.GetRecord();
        result += "Capstone Topic: " + capstoneTopic + "\n";
        return result;
    }
}