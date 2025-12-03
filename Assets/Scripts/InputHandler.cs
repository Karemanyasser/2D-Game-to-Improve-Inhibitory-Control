using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using System.IO;
public class InputHandler : MonoBehaviour
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
    public GameObject next_btn;
    // pattern to verify email
    string emailPattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
//  pattern for letters only
    string namePattern = @"^[a-zA-Z]+$"; 
      public void Validate()
    {
        bool emailStatus = ValidateInput(emailInputField,emailPattern);
        bool fnameStatus = ValidateInput(fnameInputField,namePattern);
        bool lnameStatus = ValidateInput(lnameInputField,namePattern);
        if(emailStatus && fnameStatus && lnameStatus)
        {
            AddParticipant();
            SceneManager.LoadScene("Second_Scene");
        }
    }      
      public bool ValidateInput(TMP_InputField inputField, string pattern)
    {
       
        string input = inputField.text;
        Regex re = new Regex(pattern, RegexOptions.IgnoreCase);
         if (re.IsMatch(input))
        {
            Debug.Log("Input is valid!");
            return true;
        }else{
            Debug.Log("Input is invalid!");
            return false;
        }

    }
     public void AddParticipant()
    {
        CurrentParticipant.fName = fnameInputField.text;
        CurrentParticipant.lName=lnameInputField.text;
        CurrentParticipant.Email=emailInputField.text;
        // int index = genderDropdown.value;
        CurrentParticipant.Gender=DropText(genderDropdown);
        CurrentParticipant.Day=ParseDropdown(dayDropdown);
        CurrentParticipant.Month=DropText(monthDropdown);
        CurrentParticipant.Year=ParseDropdown(yearDropdown);
        CurrentParticipant.EductionYears=ParseDropdown(yoeDropdown);
        Debug.Log("Collected user data: " + CurrentParticipant.StringData());
         
    }
    public string DropText(TMP_Dropdown Dropdown)
    {
        int index = Dropdown.value; // get index of selected option
        string text = Dropdown.options[index].text; // get text of that option
        return text;
    }
    public int ParseDropdown (TMP_Dropdown Dropdown)
    {
        string selectedText = DropText(Dropdown);
        // int index = Dropdown.value; // get index of selected option
        // string text = Dropdown.options[index].text; // get text of that option
        // Convert to integers
        int intOutput;
        int.TryParse(selectedText, out intOutput);
        return intOutput;

    }
    
}
