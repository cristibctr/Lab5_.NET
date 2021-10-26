namespace INET.ISP.LAB5
{
    public interface IRestaurant
    {
        void AcceptOnlineOrder();
        void AcceptTelephoneOrder();

        void AcceptWalksInCustomerOrder();
        void PayOnline();

        void PayInPerson();
    } 
}
