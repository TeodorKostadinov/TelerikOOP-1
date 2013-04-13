using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Display
{
    //fields
    private int? size;
    private long? colors;
    //access fields-properties
    public int? Size
    {
        get { return this.size; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Value must be positive");
            else this.size = value;
        }
    }
    public long? Colors
    {
        get { return this.colors; }
        set 
        { 
           if (value < 0)
               throw new ArgumentOutOfRangeException("Value must be positive"); 
           else this.colors = value; 
           
        }
    }
    //constructors
    public Display(int? dsize,long? dcolors)
    {
        this.size = dsize;
        this.colors = dcolors;
    }
    public Display(int dsize):this(dsize,null)
    {
    }
    public Display():this(null,null)
    {
    }
}
