using System.Collections.Generic;
using System.Linq;
using projeApi.Entities;
using projeApi.Entities.appEntities;
using projeApi.Abstract;
namespace projeApi.Concrete
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly Context _context;
        public CompanyRepository(Context context)
        {
            _context = context;
        }
        public Company CreateCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return company;
        }
        public void DeleteCompany(int id)
        {
            var company = GetCompanyById(id);
            if (company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
            }
        }
        public List<Company> GetAll()
        {
            return _context.Companies.ToList();
        }
        public Company GetCompanyById(int id)
        {
            return _context.Companies.Find(id);
        }
        public Company UpdateCompany(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
            return company;
        }
    }
}