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
	/// Select the records to send the direct email to
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum bulkemail_recipients
	{
		
		/// <summary>
		/// Send direct email only to the records you selected on this page.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Selectedrecordsoncurrentpage = 1,
		
		/// <summary>
		/// Send direct email to all the records on this page.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Allrecordsoncurrentpage = 2,
		
		/// <summary>
		/// Send direct email to all the records on all the pages in the current view.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Allrecordsonallpages = 3,
	}
}
#pragma warning restore CS1591
