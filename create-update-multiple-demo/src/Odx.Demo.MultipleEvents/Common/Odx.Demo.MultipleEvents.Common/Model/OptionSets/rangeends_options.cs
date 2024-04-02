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

namespace Odx.Demo.MultipleEvents.Common.Model
{
	
	
	/// <summary>
	/// Choose when the appointment should end
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum rangeends_options
	{
		
		/// <summary>
		/// The appointment series never ends
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Never = 1,
		
		/// <summary>
		/// The appointment series ends after a specified number of occurences
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Bynumberofoccurrences = 2,
		
		/// <summary>
		/// The appointment series ends by a specied end date
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Byenddate = 3,
	}
}
#pragma warning restore CS1591
