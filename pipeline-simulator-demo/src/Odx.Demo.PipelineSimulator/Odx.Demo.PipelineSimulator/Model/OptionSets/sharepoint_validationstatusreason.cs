#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Odx.Demo.Model
{
	
	
	/// <summary>
	/// Validation status reason of the record URL.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum sharepoint_validationstatusreason
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		ThisrecordsURLhasnotbeenvalidated = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		ThisrecordsURLisvalid = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		ThisrecordsURLisnotvalid = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		TheURLschemesofMicrosoftDynamics365andSharePointaredifferent = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		TheURLcouldnotbeaccessedbecauseofInternetExplorersecuritysettings = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Authenticationfailure = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Invalidcertificates = 7,
	}
}
#pragma warning restore CS1591
