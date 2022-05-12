using ClassRegistrationApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassRegistrationApi.Controllers;

[Route("registrations")]
[ApiController]
public class RegistrationController : ControllerBase
{

    [HttpPost]
    public async Task<ActionResult<Registration>> AddARegistration([FromBody] RegistrationRequest request)
    {
        
        var response = new Registration("99", request);

        return Ok(response);

    }
}
// {name: 'Henry Gonzalez', dateOfCourse: '2022-06-07T00:00:00', course: '62797b1a1823357feb3756ac'}
