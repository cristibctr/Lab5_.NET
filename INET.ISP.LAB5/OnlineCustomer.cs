using System;

namespace INET.ISP.LAB5
{
    public class OnlineCustomer : IRestaurant
    {
        public void AcceptOnlineOrder()
        {
            // do something
        }

        public void AcceptTelephoneOrder()
        {
            throw new NotImplementedException();
        }

        public void AcceptWalksInCustomerOrder()
        {
            throw new NotImplementedException();
        }

        public void PayInPerson()
        {
            throw new NotImplementedException();
        }

        public void PayOnline()
        {
            // do something
        }
    }
}
