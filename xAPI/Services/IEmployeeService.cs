using xAPI.Models;
using xAPI.Dto;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Services
{
    // interface: IEmployeeService | to expose the methods with utilization
    public interface IEmployeeService
    {
        public List<EmployeeDetailsDto> GetAllEmpDetails();
        public List<EmployeeDetailsDto> GetEmpDetailsById(string empId);
        public List<EmployeeDetailsDto> GetEmpDetailsByName(string empName);
        public List<EmployeeDetailsDto> GetEmpDetailsByGender(string empGender);
        public List<EmployeeDetailsDto> GetEmpDetailsByPhone(string empPhone);
        public List<EmployeeDetailsDto> GetEmpDetailsByEmail(string empEmail);
        public List<EmployeeDetailsDto> GetEmpDetailsByBirthDate(string empBirthdate);
        public List<EmployeeDetailsDto> GetEmpDetailsByJoinDate(string empJoindate);
        public string SaveNewEmpDetails(EmployeeDetailsModel submittedDetails);
        public string UpdateEmpDetails(string empId, EmployeeDetailsModel submittedDetails);
        public string DeleteEmpDetails(string empId);
    }

    // class: EmployeeService | to consume the service methods
    public class EmployeeService : IEmployeeService
    {
        // varibale: SQLite DB context
        private readonly AppDbContext _stridexDbContext;

        // cnstructor: EmployeeService | to initialize the class variables
        public EmployeeService(AppDbContext stridexDbContext)
        {
            _stridexDbContext = stridexDbContext;
        }


        /*
        *   methods type: services
        *   CRUD type: read
        *   return: employee details
        */

        // get all employees details
        public List<EmployeeDetailsDto> GetAllEmpDetails()
        {
            // fetch all details
            var allEmpDetails = _stridexDbContext.Employees
            .Select(emp => new EmployeeDetailsDto
            {
                EmpId = emp.EmpId,
                EmpName = emp.EmpName,
                EmpGender = emp.EmpGender,
                EmpPhone = emp.EmpPhone,
                EmpEmail = emp.EmpEmail,
                EmpBirthDate = emp.EmpBirthDate,
                EmpJoinDate = emp.EmpJoinDate
            })
            .ToList();

            // return details
            return allEmpDetails.Count > 0 ? allEmpDetails : new List<EmployeeDetailsDto>();
        }

        // get employee details by Id
        public List<EmployeeDetailsDto> GetEmpDetailsById(string empId)
        {
            // fetch details by id
            var empDetails = _stridexDbContext.Employees.Where(record => record.EmpId == empId).Select(
                emp => new EmployeeDetailsDto
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpGender = emp.EmpGender,
                    EmpPhone = emp.EmpPhone,
                    EmpEmail = emp.EmpEmail,
                    EmpBirthDate = emp.EmpBirthDate,
                    EmpJoinDate = emp.EmpJoinDate
                }).ToList();

            // return details
            return empDetails.Count > 0 ? empDetails : new List<EmployeeDetailsDto>();
        }

        // get employee details by Name
        public List<EmployeeDetailsDto> GetEmpDetailsByName(string empName)
        {
            // fetch details by name
            var empDetails = _stridexDbContext.Employees.Where(record => record.EmpName == empName).Select(
                emp => new EmployeeDetailsDto
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpGender = emp.EmpGender,
                    EmpPhone = emp.EmpPhone,
                    EmpEmail = emp.EmpEmail,
                    EmpBirthDate = emp.EmpBirthDate,
                    EmpJoinDate = emp.EmpJoinDate
                }).ToList();

            // return details
            return empDetails.Count > 0 ? empDetails : new List<EmployeeDetailsDto>();
        }

        // get employee details by Gender
        public List<EmployeeDetailsDto> GetEmpDetailsByGender(string empGender)
        {
            // fetch details by gender
            var empDetails = _stridexDbContext.Employees.Where(record => record.EmpGender == empGender).Select(
                emp => new EmployeeDetailsDto
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpGender = emp.EmpGender,
                    EmpPhone = emp.EmpPhone,
                    EmpEmail = emp.EmpEmail,
                    EmpBirthDate = emp.EmpBirthDate,
                    EmpJoinDate = emp.EmpJoinDate
                }).ToList();

            // return details
            return empDetails.Count > 0 ? empDetails : new List<EmployeeDetailsDto>();
        }

        // get employee details by Phone
        public List<EmployeeDetailsDto> GetEmpDetailsByPhone(string empPhone)
        {
            // fetch details by phone
            var empDetails = _stridexDbContext.Employees.Where(record => record.EmpPhone == empPhone).Select(
                emp => new EmployeeDetailsDto
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpGender = emp.EmpGender,
                    EmpPhone = emp.EmpPhone,
                    EmpEmail = emp.EmpEmail,
                    EmpBirthDate = emp.EmpBirthDate,
                    EmpJoinDate = emp.EmpJoinDate
                }).ToList();

            // return details
            return empDetails.Count > 0 ? empDetails : new List<EmployeeDetailsDto>();
        }

        // get employee deails by Email
        public List<EmployeeDetailsDto> GetEmpDetailsByEmail(string empEmail)
        {
            // fetch details by email
            var empDetails = _stridexDbContext.Employees.Where(record => record.EmpEmail == empEmail).Select(
                emp => new EmployeeDetailsDto
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpGender = emp.EmpGender,
                    EmpPhone = emp.EmpPhone,
                    EmpEmail = emp.EmpEmail,
                    EmpBirthDate = emp.EmpBirthDate,
                    EmpJoinDate = emp.EmpJoinDate
                }).ToList();

            // return details
            return empDetails.Count > 0 ? empDetails : new List<EmployeeDetailsDto>();
        }

        // get employee details by BirthDate
        public List<EmployeeDetailsDto> GetEmpDetailsByBirthDate(string empBirthdate)
        {
            DateTime birthDate = DateTime.Parse(empBirthdate);

            // fetch details by birth date
            var empDetails = _stridexDbContext.Employees.Where(record => record.EmpBirthDate == birthDate).Select(
                emp => new EmployeeDetailsDto
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpGender = emp.EmpGender,
                    EmpPhone = emp.EmpPhone,
                    EmpEmail = emp.EmpEmail,
                    EmpBirthDate = emp.EmpBirthDate,
                    EmpJoinDate = emp.EmpJoinDate
                }).ToList();

            // return details
            return empDetails.Count > 0 ? empDetails : new List<EmployeeDetailsDto>();
        }

        // get employee details by JoinDate
        public List<EmployeeDetailsDto> GetEmpDetailsByJoinDate(string empJoindate)
        {
            DateTime joinDate = DateTime.Parse(empJoindate);

            // fetch details by join date
            var empDetails = _stridexDbContext.Employees.Where(record => record.EmpJoinDate == joinDate).Select(
                emp => new EmployeeDetailsDto
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpGender = emp.EmpGender,
                    EmpPhone = emp.EmpPhone,
                    EmpEmail = emp.EmpEmail,
                    EmpBirthDate = emp.EmpBirthDate,
                    EmpJoinDate = emp.EmpJoinDate
                }).ToList();

            // return details
            return empDetails.Count > 0 ? empDetails : new List<EmployeeDetailsDto>();
        }


        /*
        *   methods type: services
        *   CRUD type: create
        *   return: status message as string
        */

        // save new employee details
        public string SaveNewEmpDetails(EmployeeDetailsModel submittedDetails)
        {
            // check if user exists 
            var validUserId = _stridexDbContext.Employees.FirstOrDefault(record => record.EmpId == submittedDetails.EmpId);

            // if not found
            if (validUserId == null)
            {
                // add to database
                _stridexDbContext.Employees.Add(submittedDetails);
                // update database
                int operationStatus = _stridexDbContext.SaveChanges();
                // return message
                return operationStatus <= 0 ? "Unexpected error occured" : "New employee details added successfully";
            }

            // else
            else
            {
                return "records already exists with employee Id";
            }



        }

        /*
        *   methods type: services
        *   CRUD type: update
        *   return: status message as string
        */

        // update employee details
        public string UpdateEmpDetails(string empId, [FromBody] EmployeeDetailsModel submittedDetails)
        {
            // check if user exists
            var existingEmployee = _stridexDbContext.Employees.FirstOrDefault(record => record.EmpId == empId);

            // if found
            if (existingEmployee != null)
            {
                // fetch properties of employee details model
                var properties = typeof(EmployeeDetailsModel).GetProperties();
                
                // navigate through each property of employee details model
                foreach (var property in properties)
                {
                    // store new value from submitted details model for each matching property of employee details model
                    var newValue = property.GetValue(submittedDetails);

                    // set new value to property of employee details model if not empty or null
                    if (newValue != null && !property.PropertyType.IsValueType || (property.PropertyType.IsValueType && !newValue.Equals(Activator.CreateInstance(property.PropertyType))))
                    {
                        // update values
                        property.SetValue(existingEmployee, newValue);
                    }
                }

                // update properties
                // existingEmployee.EmpPassword = submittedDetails.EmpPassword;
                // existingEmployee.EmpName = submittedDetails.EmpName;
                // existingEmployee.EmpGender = submittedDetails.EmpGender;
                // existingEmployee.EmpPhone = submittedDetails.EmpPhone;
                // existingEmployee.EmpEmail = submittedDetails.EmpEmail;
                // existingEmployee.EmpBirthDate = submittedDetails.EmpBirthDate;
                // existingEmployee.EmpJoinDate = submittedDetails.EmpJoinDate;


                // save updated details
                _stridexDbContext.Employees.Update(existingEmployee);

                // update database
                int operationStatus = _stridexDbContext.SaveChanges();

                // return message
                return operationStatus <= 0 ? "Unexpected error occured" : "Employee details updated successfully";
            }

            // else
            else
            {
                return "no records found for employee Id";
            }
        }

        /*
        *   methods type: services
        *   CRUD type: delete
        *   return: status message as string
        */

        // delete employee details
        public string DeleteEmpDetails(string empId)
        {
            // check if user exists
            var validUser = _stridexDbContext.Employees.FirstOrDefault(record=>record.EmpId == empId);

            // if found
            if(validUser != null)
            {
                // delete the employee details
                _stridexDbContext.Employees.Remove(validUser);
                // update the database
                _stridexDbContext.SaveChanges();
                int operationStatus = _stridexDbContext.SaveChanges();  Console.WriteLine($"Employee: Delete Operation Status -->> {operationStatus}");
                // return message
                return operationStatus < 0 ? "Unexpected error occured" : "Employess details deleted successfully"; 

            }

            // else
            else
            {
                return "no records found to be deleted";
            }
        }


    }
}