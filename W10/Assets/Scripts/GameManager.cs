using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // NYUPerson mattParker = new NYUStaff();
        // mattParker.name = "Matt Parker";
        // mattParker.nNumber = 38743783478;
        // mattParker.netId = "mp612";
        // mattParker.age = 42;
        //
        // Debug.Log(mattParker.GetRecord());
        //
        // NYUStudent rio = new NYUStudent();
        // rio.name = "Rio";
        // rio.nNumber = 323443342;
        // rio.netId = "rr1322";
        // rio.age = 45;
        // rio.gradYear = 2026;
        //
        // Debug.Log(rio.GetRecord());
        //
        // NYUPerson Frank = new NYUPerson(
        //     "f42",
        //     "Frank Lantz",
        //     23423432,
        //     62
        //     );
        //
        // Debug.Log(Frank.GetRecord());
        
        NYUUnGradStudent undergrad = new NYUUnGradStudent(
            "jz1234", 
            "Johnny", 
            1234567890, 
            23, 
            2026, 
            "AI in Game Design");
        
        Debug.Log(undergrad.GetRecord());

        NYUGradStudent grad = new NYUGradStudent(
            "em4569", 
            "Emily", 
            9876543210, 
            28, 
            2024, 
            "Mechanical Engineering");
        
        Debug.Log(grad.GetRecord());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
