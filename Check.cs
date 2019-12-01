class Check : Payment
{
string Bank; // bank name
string custName; // customer/client name
string accNum; // account number

public override Bool verify()
{
    Console.WriteLine("Signature and account Balance verified");
    return true; 

}
    public override string PaymentType => "Check";


}