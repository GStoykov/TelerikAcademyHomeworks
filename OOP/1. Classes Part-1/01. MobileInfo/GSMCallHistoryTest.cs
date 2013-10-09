// Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
// Create an instance of the GSM class.
// Add few calls.
// Display the information about the calls.
// Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
// Remove the longest call from the history and calculate the total price again.
// Finally clear the call history and print it.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GSMCallHistoryTest
{
    public void PhoneCalls()
    {
        GSM myPhone = new GSM("Galaxy Note II", "Samsung");
        
        myPhone.AddCall(new DateTime(2013, 02, 1), new DateTime(), "0891111111", 1);
        myPhone.AddCall(new DateTime(2013, 02, 2), new DateTime(), "0892222222", 2);
        myPhone.AddCall(new DateTime(2013, 02, 3), new DateTime(), "0893333333", 3);
        

        // Display Call History
        foreach (var call in myPhone.CallHistory)
        {
            Console.WriteLine(call);
            Console.WriteLine();
        }

        // Dispay the bill
        Console.WriteLine("Bill: {0}lv.", myPhone.CalcBill(0.37m));

       // Remove the longest call from the history and calculate the total price again.
        myPhone.CallHistory.Remove(myPhone.CallHistory[2]);
        Console.WriteLine("Bill without longest call: {0}lv.", myPhone.CalcBill(0.37m));

        //Clear CallHistory
        Console.WriteLine("Cleaned History");
        myPhone.ClearAllHistory();
        
    }
}