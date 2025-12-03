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
        List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }; // create a list of months
        List<string> genders = new List<string> {"woman", "man", "other"}; // create a list of genders
        List<string> days = new List<string>(); // create a list of days
         List<string> years = new List<string>(); // create a list of years
        int currentYear = System.DateTime.Now.Year; // current year for year dropdown
        List<string> yoe = new List<string>(); // create a list of years of education
        PopulateDropdowns(dayDropdown, days, numOptions: 1, numOptionsLimit: 31); // populate days
        PopulateDropdowns(monthDropdown, strOptions: months); // populate months
        PopulateDropdowns(yearDropdown,  years, numOptions: currentYear-100, numOptionsLimit: currentYear); // populate years
        PopulateDropdowns(yoeDropdown, yoe, numOptions: 1, numOptionsLimit: 50); // populate  years of education
        PopulateDropdowns(genderDropdown, strOptions: genders); // populate gender

    }

 
    void clearOptions(TMP_Dropdown dropdown,  List<string> options)
    {
        dropdown.ClearOptions(); //clear the options
        dropdown.AddOptions(options); // add options to dropdown 

    }
    void PopulateDropdowns(TMP_Dropdown dropdown, List<string> strOptions, int numOptions=1 ,int numOptionsLimit=0)
    {
        if (dropdown == null) Debug.LogError("DOB_Dropdown: dropdown is null");

        if (strOptions == null) Debug.LogError("DOB_Dropdown: strOptions is null");
        if (numOptionsLimit != 0) // check if input is a number option
        {
         for (int i = numOptions; i <= numOptionsLimit; i++)
        {
            strOptions.Add(i.ToString()); // add number option as a string to out list
        }}

        clearOptions(dropdown, strOptions); // add options to dropdown after clearing it 

    }
    // void PopulateDropdowns()
    // {

    //     List<string> days = new List<string>(); // create a list of days
    //     for (int i = 1; i <= 31; i++)
    //     {
    //         days.Add(i.ToString());
    //     }
    //     dayDropdown.ClearOptions(); //clear the options
    //     dayDropdown.AddOptions(days); // add the days to dropdown 


    //     List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }; // create a list of months
    //     monthDropdown.ClearOptions(); //clear the options
    //     monthDropdown.AddOptions(months); // add the months to dropdown 

    //     List<string> genders = new List<string> {"woman", "man", "other"};  
    //     genderDropdown.ClearOptions(); //clear the options
    //     genderDropdown.AddOptions(genders); // add the genders to dropdown 


    //     List<string> years = new List<string>(); // create a list of years
    //     int currentYear = System.DateTime.Now.Year;
    //     for (int i = currentYear; i >= currentYear - 100; i--)
    //     {
    //         years.Add(i.ToString());
    //     }
    //     yearDropdown.ClearOptions(); //clear the options
    //     yearDropdown.AddOptions(years); // add the days to dropdown
        
    //     List<string> yoe = new List<string>(); // create a list of yoe
    //             for (int i = 1; i <= 50; i++)
    //             {
    //                 yoe.Add(i.ToString());
    //             }
    //             yoeDropdown.ClearOptions(); //clear the options
    //             yoeDropdown.AddOptions(yoe); // add to the yoe dropdown

        
        
    //         } 
}
