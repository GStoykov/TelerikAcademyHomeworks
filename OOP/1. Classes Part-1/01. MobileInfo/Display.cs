using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Display
{
    // Fields
    private double? displaySize; 
    private int? displayNumOfColors; 

    // Constructors
    public Display(double? displaySize, int? displayNumOfColors)
    {
        this.DisplaySize = displaySize;
        this.DisplayNumOfColors = displayNumOfColors;
    }

    public Display(double? displaySize) :this(displaySize, null)
    {
    }

    public Display(int? displayNumOfColors) :this(null, displayNumOfColors)
    {
    }


    // Properties
    public double? DisplaySize
    {
        get
        {
            return this.displaySize;
        }
        set
        {
            this.displaySize = value;
        }
    }

    public int? DisplayNumOfColors 
    {
        get
        {
            return this.displayNumOfColors;
        }
        set
        {
            this.displayNumOfColors = value;
        }
    }

}
