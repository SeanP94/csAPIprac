using Microsoft.AspNetCore.Mvc;


namespace NZWalks_API.Controllers;

// https://localhost:{portnumber}/api/students
[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase {
    [HttpGet]
    public IActionResult GetAllStudents() {
        // Test
        string[] myStudents = new string[] {"Fred", "James", "Henry", "Mark"};

        // 200 Result        
        return Ok(myStudents);
    }
}
