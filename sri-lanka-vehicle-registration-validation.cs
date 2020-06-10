/*
Sri Lanka vehicle number validation using asp .net regular expressions
Sumith Harshan
*/


// In your Model file

[Required(ErrorMessage = "Required")]
[MaxLength(8, ErrorMessage = "Must be less than 8 characters")]
[RegularExpression(@"^([A-Z]{2,3}|((?!0*-)[0-9]{1,3}))-[0-9]{4}(?!0{4})$", ErrorMessage = "Invalid vehicle number")]  
[Display(Name = "Vehicle Number")]
public string VehicleNumber { get; set; }




/*
You can use the below method in your view file
*/
<input class="form-control valid" 
     data-val="true" 
     data-val-maxlength="Vehicle number must be less than 8 characters" 
     data-val-maxlength-max="8" 
     data-val-required="Required" 
     data-val-regex="Invalid vehicle number"
     data-val-regex-pattern="^([A-Z]{2,3}|((?!0*-)[0-9]{1,3}))-[0-9]{4}(?!0{4})$"
     id="VehicleNumber" 
     name="VehicleNumber"  
     type="text" />
     
     
