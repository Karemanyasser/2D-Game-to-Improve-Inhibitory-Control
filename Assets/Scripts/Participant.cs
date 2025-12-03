using UnityEngine;

[System.Serializable]
public class Participant
{
    public string fName;
    public string lName;
    public string Email;
     public string Gender;

    public int Day;
    public string Month;
    public int Year;

    public int EductionYears;
   

    public string StringData()
    {
        return $"Name: {fName} {lName}, Email: {Email}, DOB: {Day:00}/{Month:00}/{Year}, Years of Education: {EductionYears}, Gender: {Gender} ";
    }
}
