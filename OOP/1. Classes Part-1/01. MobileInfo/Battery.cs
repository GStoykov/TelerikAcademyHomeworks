using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BatteryType
{
    NiMH, NiCd, LiIon

}

public class Battery
{
    // Fields
    private BatteryType battModel; 
    private int? idleHours; 
    private int? talkHours; 

    // Constructors
    public Battery(BatteryType battModel) :this(battModel, null, null)
    {
    }
    public Battery(int? idleHours, int? talkHours) :this(BatteryType.LiIon, idleHours, talkHours)
    {
    }
    public Battery(BatteryType battModel, int? idleHours, int? talkHours)
    {
        this.BattModel = battModel;
        this.IdleHours = idleHours;
        this.TalkHours = talkHours;
    }

    // Properties
    public BatteryType BattModel
    {
        get
        {
            return this.battModel;
        }
        set
        {
            this.battModel = value;
        }
    }

    public int? IdleHours
    {
        get
        {
            return this.idleHours;
        }
        set
        {
            this.idleHours = value;
        }
    }

    public int? TalkHours
    {
        get
        {
            return this.talkHours;
        }
        set
        {
            this.talkHours = value;
        }
    }
}
