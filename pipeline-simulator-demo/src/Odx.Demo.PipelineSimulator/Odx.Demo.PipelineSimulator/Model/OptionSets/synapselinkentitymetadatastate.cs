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
	/// Synapse Link entity metadata state
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum synapselinkentitymetadatastate
	{
		
		/// <summary>
		/// None state for flag enumeration. Not a valid state for usage
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		None = 0,
		
		/// <summary>
		/// Not created
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		NotCreated = 1,
		
		/// <summary>
		/// Metadata creating
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		MetadataCreating = 2,
		
		/// <summary>
		/// Relationship creating
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		RelationshipCreating = 4,
		
		/// <summary>
		/// Created
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Created = 8,
		
		/// <summary>
		/// Failure
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Failure = 16,
	}
}
#pragma warning restore CS1591
