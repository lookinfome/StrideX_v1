using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using xAPI.Services;
using xAPI.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace xAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    // class: EmployeeController | to handle HTTP requests based on business logic
    public class EmployeeController : ControllerBase
    {
        // variable: employee service | to access services
        private readonly IEmployeeService _employeeService;

        // constructor: TokenController | to initialize class variables
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet("FetchAllEmpDetails")]
        [Authorize]
        public IActionResult FetchAllEmpDetails()
        {
            var allEmpDetails = _employeeService.GetAllEmpDetails();

            return allEmpDetails.Count > 0 ? Ok(new { allEmpDetails }) : NotFound(new { details = new {} });

        }

        [HttpGet("FetchEmpDetailById")]
        [Authorize]
        public IActionResult FetchEmpDetailsById(string empId)
        {
            var empDetails = _employeeService.GetEmpDetailsById(empId);

            return empDetails.Count > 0 ? Ok(new {empDetails}) : NotFound(new {details = new {}});
        }

        [HttpGet("FetchEmpDetailByName")]
        [Authorize]
        public IActionResult FetchEmpDetailByName(string empName)
        {
            var empDetails = _employeeService.GetEmpDetailsById(empName);

            return empDetails.Count > 0 ? Ok(new {empDetails}) : NotFound(new {details = new {}});
        }

        [HttpGet("FetchEmpDetailByGender")]
        [Authorize]
        public IActionResult FetchEmpDetailByGender(string empGender)
        {
            var empDetails = _employeeService.GetEmpDetailsById(empGender);

            return empDetails.Count > 0 ? Ok(new {empDetails}) : NotFound(new {details = new {}});
        }

        [HttpGet("FetchEmpDetailByPhone")]
        [Authorize]
        public IActionResult FetchEmpDetailByPhone(string empPhone)
        {
            var empDetails = _employeeService.GetEmpDetailsById(empPhone);

            return empDetails.Count > 0 ? Ok(new {empDetails}) : NotFound(new {details = new {}});
        }

        [HttpGet("FetchEmpDetailByEmail")]
        [Authorize]
        public IActionResult FetchEmpDetailByEmail(string empEmail)
        {
            var empDetails = _employeeService.GetEmpDetailsById(empEmail);

            return empDetails.Count > 0 ? Ok(new {empDetails}) : NotFound(new {details = new {}});
        }

        [HttpGet("FetchEmpDetailByBirthDate")]
        [Authorize]
        public IActionResult FetchEmpDetailByBirthDate(string empBirthdate)
        {
            var empDetails = _employeeService.GetEmpDetailsById(empBirthdate);

            return empDetails.Count > 0 ? Ok(new {empDetails}) : NotFound(new {details = new {}});
        }

        [HttpGet("FetchEmpDetailByJoinDate")]
        [Authorize]
        public IActionResult FetchEmpDetailByJoinDate(string empJoindate)
        {
            var empDetails = _employeeService.GetEmpDetailsById(empJoindate);

            return empDetails.Count > 0 ? Ok(new {empDetails}) : NotFound(new {details = new {}});
        }

        [HttpPost("SaveNewEmpDetails")]
        [Authorize]
        public IActionResult SaveNewEmpDetails(EmployeeDetailsModel submittedDetails)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string message = _employeeService.SaveNewEmpDetails(submittedDetails);
                    return Ok(new { message });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { message = "An error occurred while saving employee details." });
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("UpdateEmpDetails")]
        [Authorize]
        public IActionResult UpdateEmpDetails(string empId, EmployeeDetailsModel submittedDetails)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    string message = _employeeService.UpdateEmpDetails(empId, submittedDetails);
                    return Ok(new {message});
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { message = "An error occurred while saving employee details." });
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    
        [HttpDelete("DeleteEmpDetails")]
        [Authorize]
        public IActionResult DeleteEmpDetails(string empId)
        {
            string message = _employeeService.DeleteEmpDetails(empId);

            return Ok(new {message});
        }
    
    }

}