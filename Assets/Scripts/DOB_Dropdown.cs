using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class DOB_Dropdown : MonoBehaviour
{
    // dropdown population
    [SerializeField] public TMP_Dropdown dayDropdown; // day dropdown to populate
    [SerializeField] public TMP_Dropdown monthDropdown; // month dropdown to populate
    [SerializeField] public TMP_Dropdown yearDropdown; // year dropdown to populate
    [SerializeField] public TMP_Dropdown yoeDropdown; // years of education dropdown to populate
     [SerializeField] public TMP_Dropdown genderDropdown; // gender dropdown to populate
    
    void Start()
    {
        PopulateDropdowns();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void PopulateDropdowns()
    {

        List<string> days = new List<string>(); // create a list of days
        for (int i = 1; i <= 31; i++)
        {
            days.Add(i.ToString());
        }
        dayDropdown.ClearOptions(); //clear the options
        dayDropdown.AddOptions(days); // add the days to dropdown 


        List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }; // create a list of months
        monthDropdown.ClearOptions(); //clear the options
        monthDropdown.AddOptions(months); // add the months to dropdown 

        List<string> genders = new List<string> {"woman", "man", "other"};  
        genderDropdown.ClearOptions(); //clear the options
        genderDropdown.AddOptions(genders); // add the genders to dropdown 


        List<string> years = new List<string>(); // create a list of years
        int currentYear = System.DateTime.Now.Year;
        for (int i = currentYear; i >= currentYear - 100; i--)
        {
            years.Add(i.ToString());
        }
        yearDropdown.ClearOptions(); //clear the options
        yearDropdown.AddOptions(years); // add the days to dropdown
        
        List<string> yoe = new List<string>(); // create a list of yoe
                for (int i = 1; i <= 50; i++)
                {
                    yoe.Add(i.ToString());
                }
                yoeDropdown.ClearOptions(); //clear the options
                yoeDropdown.AddOptions(yoe); // add to the yoe dropdown

        
        
            } 
}
