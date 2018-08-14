using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInterface
{
    public interface ICompany
    {
        Boolean InsertCompany(company tmpcompany);
    }
    public class CompanyOperationRepo : ICompany
    {
        efDBEntities _db = new efDBEntities();
        public Boolean InsertCompany(company tmpcompany)
        {
            if (tmpcompany.company_name != null)
                using (_db)
                {
                    _db.company.Add(tmpcompany);
                    _db.SaveChanges();
                    return true;
                }
            throw new ArgumentException();
        }

        public bool InsertCompany(global::MockUnit.company company)
        {
            throw new NotImplementedException();
        }
    }  
    public class CompanyClass  
    {  
        ICompany company = null;  
        public void CompanyCRUD(ICompany tmpCompany)  
        {  
            company = tmpCompany;  
        }  
        public Boolean InsertCompany(company Company)  
        {  
            return company.InsertCompany(Company);  
        }  
    }   
} 

