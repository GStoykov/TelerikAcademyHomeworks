using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GSM
{
    public Battery Battery = new Battery(BatteryType.LiIon, 9, 30);
    public Display Display = new Display(4.5, null);
    public Call Call = new Call(new DateTime(), "", 0);


    // iPhone4S
    static private GSM iPhone4S = new GSM("iPhone4S", "Apple", 999.99);

    // Fields
    private string model; 
    private string manifacturer; 
    private double? price; 
    private string owner;    

    // Constructors
    public GSM(string model, string manifacturer):this(model, manifacturer, null, null)       
    {
    }

    public GSM(string model, string manifacturer, double? price) :this(model, manifacturer, price, null)
    {

    }

    public GSM(string model, string manifacturer, string owner) :this(model, manifacturer, null, owner)
    {
        
    }

    public GSM(string model, string manifacturer, double? price, string owner)
    {
        this.Model = model;
        this.Manifacturer = manifacturer;
        this.Price = price;
        this.Owner = owner;
    }

    public GSM(string model, string manifacturer, Display display) : this(model, manifacturer)
    {
        this.Display = display; 
    }

    // Properties
    public string Model
    {
        get
        {
            return this.model;
        }
         set
        {
            if (value.Length >= 0)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException("Invalid input. Mobiles`s model name should consist at least 2 characters.");                
            }
        }
    }

    public string Manifacturer
    {
        get
        {
            return this.manifacturer;
        }
        set
        {
            if (value.Length >= 0)
            {
                this.manifacturer = value;
            }
            else
            {
                throw new ArgumentException("Invalid input. Mobiles`s manifacturer name should consist at least 2 characters.");
            }
        }
    }

    public double? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;
            //if (value >= 0 || value == null)
            //{
            //    this.price = value;
            //}
            //else
            //{
            //    throw new ArgumentException("Invalid price.");
            //}
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            this.owner = value;
            //if (value.Length >= 0 || value == null)
            //{
            //    this.owner = value;
            //}
            //else
            //{
            //    throw new ArgumentException("Invalid input. Mobiles`s owner name should consist at least 2 characters.");
            //}
        }
    }

        // iPhone`s property
    public static GSM IPhone4S
    {
        get
        {
            return iPhone4S;
        }
    }

        // Call History`s property
    public List<Call> CallHistory = new List<Call>();

    // Methods
    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.Append("\t GSM:");
        text.AppendFormat("\nModel: {0}", this.model);
        text.AppendFormat("\nManifacturer: {0}", this.manifacturer);
        text.AppendFormat("\nOwner: {0}", this.owner);
        text.AppendFormat("\nPrice: {0}", this.price);
        return text.ToString();
    }

    // Call History`s methods
    public void AddCall(DateTime date, DateTime time, string dialedPhone, int duration)
    {
        Call newCall = new Call(date, time, dialedPhone, duration);
        CallHistory.Add(newCall);
    }

    public void RemoveCall(string number)
    {
        for (int i = 0; i < CallHistory.Count; i++)
        {
            if (CallHistory[i].DialedPhone == number)
            {
                CallHistory.RemoveAt(i);
                i--;
            }
        }
    }

    public void ClearAllHistory()
    {
        CallHistory.Clear();
    }

    // Method for calculating GSM`s bill
    public decimal CalcBill(decimal minCost)
    {
        int talkedTime = 0;
        for (int i = 0; i < CallHistory.Count; i++)
        {
            talkedTime += CallHistory[i].Duration;
        }
        return (decimal)talkedTime * minCost;
    }
}
