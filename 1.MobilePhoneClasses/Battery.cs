using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Battery
{
    //fields
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    private string model;
    private double? hoursIdl;
    private double? hoursTlk;
    private BatteryType batType;
    //access fields
    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public double? IdleHours
    {
        get { return this.hoursIdl; }
        set
        { 
            if (value < 0)
                    throw new ArgumentOutOfRangeException("Value must be positive"); 
                else this.hoursIdl = value; 
        
        }
    }
    public double? TalkHours
    {
        get { return this.hoursTlk; }
        set
        { 
            if (value < 0)
                    throw new ArgumentOutOfRangeException("Value must be positive"); 
                else this.hoursTlk = value; 
            
        }
    }
    public BatteryType BatType
    {
        get { return this.batType; }
        set { this.batType = value; }
    }
    //constructors
    public Battery(string bmodel,double? bhoursI,double? bhoursT)
    {
        this.model = bmodel;
        this.hoursIdl = bhoursI;
        this.hoursTlk = bhoursT;
    }
    public Battery(string bmodel, double bhoursI):this(bmodel,bhoursI,null)
    {
    }
    public Battery(string bmodel):this(bmodel,null,null)
    {
    }
    public Battery():this(null,null,null)
    {
    }
}
