using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GSM
{
    //fields
    private string model;
    private string manufactorer;
    private double? price;
    private string owner;
    public Battery Battery;
    public Display Display;
    private List<Call> callHistory =new List<Call>();
    //static field
    private static GSM iphone=new GSM("iphone","apple",700);
    //access to fields-properties
    public string Model
    {
        get{return this.model;}
        set{this.model=value;}
    }
    public string Manufactorer
    {
        get{return this.manufactorer;}
        set{this.manufactorer=value;}
    }
    public double? Price
    {
        get{return this.price;}
        set
        { 
            if (value < 0)
                    throw new ArgumentOutOfRangeException("Value must be positive"); 
                else this.price =value; 
            
        }
    }
    public string Owner
    {
        get{return this.owner;}
        set{this.owner=value;}
    }
    public static GSM IPhone4S
    {
        get{return iphone;}
    }
    public List<Call> CallHistory
    {
        get{return callHistory;}
    }
    //constructors
    public GSM(string smodel, string smanufactor, double? sprice, string sowner,string batModel,double? batTalkHours,double? batIdlHours,int? displSize,long? displColors)
    {
        this.model = smodel;
        this.manufactorer = smanufactor;
        this.price = sprice;
        this.owner = sowner;
        Battery = new Battery(batModel,batTalkHours,batIdlHours);
        Display = new Display(displSize,displColors);
    }
    public GSM(string smodel, string smanufactor, double sprice, string sowner, string batModel, double batTalkHours, double batIdlHours, int displSize):this(smodel,smanufactor,sprice,sowner,batModel,batTalkHours,batIdlHours,displSize,null)
    {
    }
    public GSM(string smodel, string smanufactor, double sprice, string sowner, string batModel, double batTalkHours, double batIdlHours)
        : this(smodel, smanufactor, sprice, sowner, batModel, batTalkHours, batIdlHours, null, null)
    {
    }
    public GSM(string smodel, string smanufactor, double sprice, string sowner, string batModel, double batTalkHours)
        : this(smodel, smanufactor, sprice, sowner, batModel, batTalkHours, null, null, null)
    {
    }
    public GSM(string smodel, string smanufactor, double sprice, string sowner, string batModel)
        : this(smodel, smanufactor, sprice, sowner, batModel, null, null, null, null)
    {
    }
    public GSM(string smodel, string smanufactor, double sprice, string sowner)
        : this(smodel, smanufactor, sprice, sowner, null, null, null, null, null)
    {
    }
    public GSM(string smodel, string smanufactor, double sprice)
        : this(smodel, smanufactor, sprice, null, null, null, null, null, null)
    {
    }
    public GSM(string smodel, string smanufactor)
        : this(smodel, smanufactor, null, null, null, null, null, null, null)
    {
    }
    // display info
    public override string ToString()
    {
        StringBuilder sb=new StringBuilder();
        
        sb.AppendLine("Model: " + this.model);
        sb.AppendLine("Manufactorer: "+this.manufactorer.ToString());
        sb.AppendLine("Price: "+this.price);
        sb.AppendLine("Owner: "+this.owner);
        sb.AppendLine("Battery Model: "+ this.Battery.Model);
        sb.AppendLine("Battery Idle and Talk time: "+this.Battery.IdleHours+" "+this.Battery.TalkHours);
        sb.AppendLine("Battery type: "+this.Battery.BatType);
        sb.AppendLine("Display Size: "+this.Display.Size);
        sb.AppendLine("Number of colors: "+this.Display.Colors);

        return sb.ToString();
    }
    //methods
    public void AddCall(DateTime time,string number,long duration)
    {
        Call oneCall = new Call(time, number, duration);
        callHistory.Add(oneCall);
    }
    public void AddCall(long duration)
    {
        Call oneCall = new Call(duration);
        callHistory.Add(oneCall);
    }
    public void DeleteCall(long duration)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == duration)
            {
                callHistory.RemoveAt(i);
                i--;
            }
        }
    }
    public void ClearAllCalls()
    {
        callHistory.Clear();
    }
    public double CallPrice(double tarifa)
    {
        double payment=0;
        foreach (var cal in callHistory)
	    {
		    payment=payment+(cal.Duration/60)*tarifa;
	    }
        return payment;
    }
    public void DisplayCalls()
    {
        foreach (var call in callHistory)
        {
            Console.WriteLine(call);
        }
    }
}



