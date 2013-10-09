// Write a class GSMTest to test the GSM class:
//  - Create an array of few instances of the GSM class.
//  - Display the information about the GSMs in the array.
//  - Display the information about the static property IPhone4S.

using System;
using System.Collections.Generic;
using System.Linq;

public class GSMTest
{
    // Fields
    public GSM[] arrOfMobiles = new GSM[4];

    private GSM mobile1 = new GSM("One X", "HTC");
    private GSM mobile2 = new GSM("Galaxy III", "Samsung", 4.5);
    private GSM mobile3 = new GSM("Galaxy Note II", "Samsung", 749.99, "Georgi");
    private GSM mobile4 = new GSM(GSM.IPhone4S.Model, GSM.IPhone4S.Manifacturer, GSM.IPhone4S.Price);

    // Class`s constructor
    public GSMTest()
    {
        this.arrOfMobiles[0] = mobile1;
        this.arrOfMobiles[1] = mobile2;
        this.arrOfMobiles[2] = mobile3;
        this.arrOfMobiles[3] = mobile4;
    }

    // Property 
    public GSM[] ArrOfMobiles
    {
        get
        {
            return this.arrOfMobiles;
        }
    }

}