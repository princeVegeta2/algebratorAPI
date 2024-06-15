using Microsoft.AspNetCore.Mvc;
using detAPI.Classes;
using System.Collections.Generic;

namespace detAPI.Controllers
{
    [ApiController]
    [Route("api/algebra")]
    public class DetController : ControllerBase
    {
        [HttpPost("calc_det")]
        public IActionResult CalculateDeterminant([FromBody] List<List<double>> matrixValues)
        {
            int rows = matrixValues.Count;
            int columns = matrixValues[0].Count;

            if (rows != columns)
            {
                return BadRequest("Must be a square matrix");
            }

            var calculator = new Calculator(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    calculator.SetElement(i, j, matrixValues[i][j]);
                }
            }

            double determinant = calculator.CalculateDeterminant();

            return Ok(new { Determinant = determinant });
        }
    }
}
