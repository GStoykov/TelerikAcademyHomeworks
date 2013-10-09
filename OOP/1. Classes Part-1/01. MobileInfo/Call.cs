// Create a class Call to hold a call performed through a GSM. 
// It should contain date, time, dialed phone number and duration (in seconds).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Call
{

    // Fields
    private DateTime date;
    private DateTime time;
    private string dialedPhone;
    private int duration;

    // Constructors
    public Call(DateTime date, DateTime time, string dialedPhone, int duration)
    {
        this.Date = date;
        this.Time = time;
        this.DialedPhone = dialedPhone;
        this.Duration = duration;
    }

    public Call(DateTime date, string dialedPhone, int duration) :this(date, new DateTime(),dialedPhone, duration)
    {
    }

    // Properties
    public DateTime Date
    {
        get
        {
            return this.date;
        }
        set
        {
            this.date = value;
        }
    }

    public DateTime Time
    {
        get
        {
            return this.time;
        }
        set
        {
            this.time = value;
        }
    }

    public string DialedPhone
    {
        get
        {
            return this.dialedPhone;
        }
        set
        {
            this.dialedPhone = value;
        }
    }

    public int Duration
    {
        get
        {
            return this.duration;
        }
        set
        {
            this.duration = value;
        }
    }


    
    // Display the information about the calls
    public override string ToString()
    {
        StringBuilder callInfo = new StringBuilder();
        callInfo.Append("   Call Information:\n");
        callInfo.AppendFormat("\nDate: {0}", this.date);
        callInfo.AppendFormat("\nDialedNumber: {0}", this.dialedPhone);
        callInfo.AppendFormat("\nTalked time in minutes: {0}", this.duration);
        return callInfo.ToString();
    }

}

