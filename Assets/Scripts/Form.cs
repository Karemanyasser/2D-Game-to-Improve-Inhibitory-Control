using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Form : MonoBehaviour
{
    [SerializeField] public TMP_InputField fnameInputField;
    [SerializeField] public TMP_InputField lnameInputField;
    [SerializeField] public TMP_InputField emailInputField;
    [SerializeField] public TMP_Dropdown dayDropdown;
    [SerializeField] public TMP_Dropdown monthDropdown;
    [SerializeField] public TMP_Dropdown yearDropdown;
    [SerializeField] public TMP_Dropdown yoeDropdown; 
    [SerializeField] public TMP_Dropdown genderDropdown;

    public Participant CurrentParticipant { get; private set; } = new Participant();
   
    public void AddParticipant()
    {
        CurrentParticipant.fName = fnameInputField.text;
        CurrentParticipant.lName=lnameInputField.text;
        CurrentParticipant.Email=emailInputField.text;
        int index = genderDropdown.value;
        CurrentParticipant.Gender=genderDropdown.options[index].text;
        ParseDropdown(dayDropdown,CurrentParticipant.Day);
        // ParseDropdown(monthDropdown,CurrentParticipant.Month);
        ParseDropdown(yearDropdown,CurrentParticipant.Year);
        ParseDropdown(yoeDropdown,CurrentParticipant.EductionYears);
        Debug.Log("Collected user data: " + CurrentParticipant.StringData());
         
    }
    public void ParseDropdown (TMP_Dropdown Dropdown, int intOutput)
    {
        int index = Dropdown.value; // get index of selected option
        string text = Dropdown.options[index].text; // get text of that option
        // Convert to integers
        int.TryParse(text, out intOutput);

    }
}
