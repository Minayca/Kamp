using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{

    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return TaskAsync(customer).Result;
        }

        public static async Task<bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var durum = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year));
            return durum.Body.TCKimlikNoDogrulaResult;
        }
    }
    //public class MernisServiceAdapter : ICustomerCheckService

    //{
    //    public bool CheckIfRealPersonAsync(Customer customer)
    //    {
    //        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
    //        return await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
    //            customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);

    //    }
    //}
}
