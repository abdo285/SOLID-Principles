public class PaymentProcessor
{
    public void ProcessPayment(PaymentType type, double amount)
    {
        switch (type)
        {
            case PaymentType.CreditCard:
            //Process credit card payment
            break;
            case PaymentType.PayPal:
            //Process PayPal payment
            break;
            case PaymentType.BankTransfer:
            //Process bank transfer payment
            break;
            //Add more cases for other payment types
        }
    }
}

public enum PaymentType
{
    CreditCard,
    PayPal,
    BankTransfer
}