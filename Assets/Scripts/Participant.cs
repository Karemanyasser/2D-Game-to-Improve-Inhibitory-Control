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

    public int TestScore;
    public int TestMistake;

    public int GameScore;

    public string DateTimeIso;   // time the score was achieved

    public string AddTestScore(int score, int mistakes)
    {
        this.TestScore = score;
        this.TestMistake= mistakes;
        this.DateTimeIso = System.DateTime.UtcNow.ToString("o"); // ISO-8601
        return $"TestScore: {TestScore}, TestMistakes: {TestMistake} Date&Time: {DateTimeIso}, Email: {Email}";
    }
public string AddGameScore(int score)
    {
        this.GameScore = score;
        this.DateTimeIso = System.DateTime.UtcNow.ToString("o"); // ISO-8601
        return $"GameScore: {GameScore}, Date&Time: {DateTimeIso}, Email: {Email}";
    }
    public string StringData()
    {
        return $"Name: {fName} {lName}, Email: {Email}, DOB: {Day:00}/{Month:00}/{Year}, Years of Education: {EductionYears}, Gender: {Gender} ";
    }
}
