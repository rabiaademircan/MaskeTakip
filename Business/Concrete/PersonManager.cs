using Entities.Concrete;
using Business.Abstract;
using ServiceReference1;

namespace Business.Concrete;

    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return new List<Person>();
        }
        public bool CheckPerson(Person person)
        {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest
            (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, Ad: person.FirstName, Soyad: person.LastName, person.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }

    }
