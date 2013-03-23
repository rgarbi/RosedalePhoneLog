using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PhoneLog
/// </summary>
public class PhoneLog
{
    private string _callerName;
    private DateTime _callDate;
    private string _phoneNumber;
    private string _message;
    private string _messageTarget;
    private string _targetEmail;
    private string _callType;
    private Boolean _followedUp;

	public PhoneLog(string callerName, DateTime callDate, string phoneNumber, string message, string messageTarget, string targetEmail, string callType, Boolean followedUp)
	{
        _callerName = callerName;
        _callDate = callDate;
        _phoneNumber = phoneNumber;
        _message = message;
        _messageTarget = messageTarget;
        _targetEmail = targetEmail;
        _callType = callType;
        _followedUp = followedUp;
	}

    public string callerName
    {
        get { return _callerName; }
        set { _callerName = value; }
    }

    public DateTime callDate
    {
        get { return _callDate; }
        set { _callDate = value; }
    }

    public string phoneNumber
    {
        get { return _phoneNumber; }
        set { _phoneNumber = value; }
    }

    public string message
    {
        get { return _message; }
        set { _message = value; }
    }

    public string messageTarget
    {
        get { return _messageTarget; }
        set { _messageTarget = value; }
    }

    public string targetEmail
    {
        get { return _targetEmail; }
        set { _targetEmail = value; }
    }

    public string callType
    {
        get { return _callType; }
        set { _callType = value; }
    }

    public Boolean followedUp
    {
        get { return _followedUp; }
        set { _followedUp = value; }
    }
}