using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Linq;
using System.Text;
using xAPI.Models;

namespace xAPI.Services
{
    // interface: IAccountService | to expose methods without implementation
    public interface IAccountService
    {
        public bool IsEmployeeExists(string username, string password);
    }

    // class: AccountService | to consume service methods
    public class AccountService : IAccountService
    {
        // variable: SQLite Db context
        private readonly AppDbContext _stridexDBContext;

        // constructor: AccountService | to initialize class variables
        public AccountService(AppDbContext stridexDBContext)
        {
            _stridexDBContext = stridexDBContext;
        }

        /*
        *   Method: IsEmployeeExists
        *   Type: Service
        *   Purpose: to check if employee record exists or not
        *   Parameter: username, password as string
        *   return: bool value true if record exists, else false
        */
        public bool IsEmployeeExists(string username, string password)
        {
            var employeeDetails = _stridexDBContext.Employees.FirstOrDefault(record => record.EmpId == username && record.EmpPassword == password);

            if(employeeDetails != null)
            {
                return true;
            }

            return false;
        }
    }
}