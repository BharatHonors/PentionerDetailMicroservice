using PentionerDetailMicroservice.Model;
using System.Collections.Generic;
namespace PentionerDetailMicroservice.Repository
{
    public interface IPentionerDetailsRepo
    {
        public PentionerDetail PensionerDetailByAadhar(string aadhar);
        public List<PentionerDetail> GetData();

        public List<PentionerDetail> PentionerDetails();
    }
}
