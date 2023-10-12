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
	/// Stores the list of event types for system messages.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum msdyn_ocsystemmessageeventtype
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentjoinedconversation = 192350000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Consultaccepted = 192350001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transfertoagentaccepted = 192350002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Consultstarted = 192350003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Consultrequestfailed = 192350004,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transfertoagentrequested = 192350005,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transfertoagentfailed = 192350006,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Consultrejected = 192350007,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transfertoagentrejected = 192350008,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Consultrequesttimedout = 192350009,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transfertoagenttimedout = 192350010,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transfertoqueuestarted = 192350011,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transfertoqueuefailed = 192350012,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentdisconnectedfromconversation = 192350013,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentendedconversation = 192350014,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Sessionended = 192350015,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Consultsessionended = 192350016,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentassignedtoconversation = 192350017,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentcouldntbeassignedtoconversation = 192350018,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customerendedconversation = 192350019,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customerdisconnected = 192350020,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customerspositioninqueue = 192350021,
		
		/// <summary>
		/// Agent's message couldn't be sent
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentsmessagecouldntbesent = 192350022,
		
		/// <summary>
		/// Customer's message couldn't be sent: Outside of operation hours
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CustomersmessagecouldntbesentOutsideofoperationhours = 192350023,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customerisnextinline = 192350024,
		
		/// <summary>
		/// Message couldn't be delivered: Unsupported message type
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		MessagecouldntbedeliveredUnsupportedmessagetype = 192350025,
		
		/// <summary>
		/// Voice call requested
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Voicecallrequested = 192350026,
		
		/// <summary>
		/// Voice call accepted
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Voicecallaccepted = 192350027,
		
		/// <summary>
		/// Voice call declined
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Voicecalldeclined = 192350028,
		
		/// <summary>
		/// Message couldn't be sent: Outside allowed timeframe
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		MessagecouldntbesentOutsideallowedtimeframe = 192350029,
		
		/// <summary>
		/// Average wait time for customers: Minutes
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		AveragewaittimeforcustomersMinutes = 192350030,
		
		/// <summary>
		/// Average wait time for customers: Hours
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		AveragewaittimeforcustomersHours = 192350031,
		
		/// <summary>
		/// Average wait time for customers: Hours and minutes
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		AveragewaittimeforcustomersHoursandminutes = 192350032,
		
		/// <summary>
		/// Voice call ended
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Voicecallended = 192350033,
		
		/// <summary>
		/// Message couldn’t be sent: A channel account can’t message another account within Omnichannel
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		MessagecouldntbesentAchannelaccountcantmessageanotheraccountwithinOmnichannel = 192350034,
		
		/// <summary>
		/// Holiday message to customer
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Holidaymessagetocustomer = 192350035,
		
		/// <summary>
		/// Out of operating hour message to customer
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Outofoperatinghourmessagetocustomer = 192350036,
		
		/// <summary>
		/// Couldn’t find the channel account in Omnichannel
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CouldntfindthechannelaccountinOmnichannel = 192350037,
		
		/// <summary>
		/// Customer's file couldn't be attached because it's too big
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customersfilecouldntbeattachedbecauseitstoobig = 192350038,
		
		/// <summary>
		/// Transfer to out of operating hour queue
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transfertooutofoperatinghourqueue = 192350039,
		
		/// <summary>
		/// Message couldn’t be sent: File couldn’t be attached
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		MessagecouldntbesentFilecouldntbeattached = 192350040,
		
		/// <summary>
		/// Leave as many messages as you’d like and we’ll get back to you as soon as possible. We’ll save your chat history, so you can leave and come back anytime.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		LeaveasmanymessagesasyoudlikeandwellgetbacktoyouassoonaspossibleWellsaveyourchathistorysoyoucanleaveandcomebackanytime = 192350041,
		
		/// <summary>
		/// Customer put on hold.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customerputonhold = 192350042,
		
		/// <summary>
		/// Customer no longer on hold.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customernolongeronhold = 192350043,
		
		/// <summary>
		/// Message or attachment failed to send. Providing error details including error code, reason for failure, message id, timestamp, and transaction id
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		MessageorattachmentfailedtosendProvidingerrordetailsincludingerrorcodereasonforfailuremessageidtimestampandtransactionid = 192350044,
		
		/// <summary>
		/// Transcription started.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transcriptionstarted = 192350045,
		
		/// <summary>
		/// Transcription paused.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transcriptionpaused = 192350046,
		
		/// <summary>
		/// Transcription resumed.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transcriptionresumed = 192350047,
		
		/// <summary>
		/// Transcription stopped.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Transcriptionstopped = 192350048,
		
		/// <summary>
		/// Recording and transcription started.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Recordingandtranscriptionstarted = 192350049,
		
		/// <summary>
		/// Recording and transcription paused.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Recordingandtranscriptionpaused = 192350050,
		
		/// <summary>
		/// Recording and transcription resumed.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Recordingandtranscriptionresumed = 192350051,
		
		/// <summary>
		/// Recording and transcription stopped.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Recordingandtranscriptionstopped = 192350052,
		
		/// <summary>
		/// Usage limit for trial exceeded limits
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Trialusagelimitexceeded = 192350053,
		
		/// <summary>
		/// Time limit for a trial conversation exceeded
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Trialconversationtimelimitexceeded = 192350054,
		
		/// <summary>
		/// Ending the conversation when queue overflow condition met
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Endconversationduetooverflow = 192350055,
		
		/// <summary>
		/// Greeting Message for Async Channels and Voice
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		GreetingMessageforAsyncChannelsandVoice = 192350056,
		
		/// <summary>
		/// Customer has opted out from Async Conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CustomerhasoptedoutfromAsyncConversation = 192350057,
		
		/// <summary>
		/// Agent left consult conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentleftconsultconversation = 192350058,
		
		/// <summary>
		/// Agent left customer conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentleftcustomerconversation = 192350059,
		
		/// <summary>
		/// Agent accepted consult conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentacceptedconsultconversation = 192350060,
		
		/// <summary>
		/// Agent joined customer conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentjoinedcustomerconversation = 192350061,
		
		/// <summary>
		/// Agent ended consult conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentendedconsultconversation = 192350062,
		
		/// <summary>
		/// Agent removed from consult conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Agentremovedfromconsultconversation = 192350063,
		
		/// <summary>
		/// Message displayed to customer when there is not enough data to show the average wait time when the feature has been enabled
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Notenoughdataforaveragewaittime = 192350064,
		
		/// <summary>
		/// Message displayed to agent when customer is disconnected from conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Waitingtimeforagentwhencustomerisdisconnected = 192350070,
		
		/// <summary>
		/// Invalid Apple OAuth response
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		InvalidAppleOAuthresponse = 192350071,
		
		/// <summary>
		/// Supervisor force closed the conversation
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Supervisorforceclosedtheconversation = 192350072,
		
		/// <summary>
		/// Offer customer callback
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Offercustomercallback = 192350073,
		
		/// <summary>
		/// Customer callback response
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Customercallbackresponse = 192350074,
		
		/// <summary>
		/// Customer's message couldn't be sent: Service is down.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CustomersmessagecouldntbesentServiceisdown = 192370001,
	}
}
#pragma warning restore CS1591
