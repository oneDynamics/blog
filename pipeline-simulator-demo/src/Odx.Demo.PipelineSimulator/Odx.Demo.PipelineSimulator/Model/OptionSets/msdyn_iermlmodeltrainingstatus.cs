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
	/// Indicates model's recent training status
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum msdyn_iermlmodeltrainingstatus
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Nottrained = 100000000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Traininginprogress = 100000001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Trainingcompleted = 100000002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Trainingfailed = 100000003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Publishinprogress = 100000004,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Publishfailed = 100000005,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Publishcompleted = 100000006,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Loadingdata = 100000007,
	}
}
#pragma warning restore CS1591