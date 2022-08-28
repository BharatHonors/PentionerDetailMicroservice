using PentionerDetailMicroservice.Model;
using PentionerDetailMicroservice.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace PentionerDetailMicroservice.Repository
{
    public class PentionerDetailsRepo : IPentionerDetailsRepo
    {
       

        public PentionerDetail PensionerDetailByAadhar(string aadhar)
        {
            List<PentionerDetail> pensionDetails = GetData();
            return pensionDetails.FirstOrDefault(s => s.AadharNumber == aadhar);
        }

        public List<PentionerDetail> PentionerDetails()
        {
            List<PentionerDetail> pensionDetails = GetData();
            return pensionDetails;
        }

        public List<PentionerDetail> GetData()
        {
            List<PentionerDetail> pensionerdetail = new List<PentionerDetail>();
            try
            {
                //string csvConn = configuration.GetValue<string>("MySettings:CsvConnection");  // Initializing the csvConn  for the File path
                //string csvConn = "details.csv";
                using (StreamReader sr = new StreamReader(@"Data\details.csv"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        pensionerdetail.Add(new PentionerDetail() { Name = values[0], Dateofbirth = Convert.ToDateTime(values[1]), Pan = values[2], AadharNumber = values[3], SalaryEarned = Convert.ToInt32(values[4]), Allowances = Convert.ToInt32(values[5]), PensionType = (PensionTypeValue)Enum.Parse(typeof(PensionTypeValue), values[6]), BankName = values[7], AccountNumber = values[8], BankType = (BankType)Enum.Parse(typeof(BankType), values[9]) });
                    }

                }
            }
            catch (NullReferenceException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            return pensionerdetail.ToList();
        }
    }
}
