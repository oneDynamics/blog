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
	/// This option set is used to list different Field Data Formats.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum msdyn_iotfielddataformat
	{
		
		/// <summary>
		/// The field directly contains the value.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Direct = 192350000,
		
		/// <summary>
		/// The field contains a JSON containing the value desired.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		JSON = 192350001,
	}
}
#pragma warning restore CS1591
