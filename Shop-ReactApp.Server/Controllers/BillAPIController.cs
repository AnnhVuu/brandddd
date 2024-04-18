using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_ReactApp.Server.Models;
using Shop_ReactApp.Server.Reponsitory;
using System.Data.Entity;

namespace Shop_ReactApp.Server.Controllers
{
    [Route("api/Bill")]
    [ApiController]
    public class BillAPIController : ControllerBase
    {
        DataWeb db;
        private readonly IBillReponsitory _billRepository;
        public BillAPIController(IBillReponsitory billRepository)
        {
            _billRepository = billRepository;
        }
        [HttpGet]

        public async Task<IActionResult> GetBills()
        {
            try
            {
                var bill = await _billRepository.GetAllAsync();
                return Ok(bill);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Lỗi server");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBillById(string id)
        {
            try
            {
                var product = await _billRepository.GetByIdAsync(id);
                if (product == null)
                    return NotFound();
                return Ok(product);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }



        [HttpPost]
        [Route("addBill")]
        public async Task<IActionResult> AddBill([FromBody] Bills bill)
        {
            try
            {
                await _billRepository.AddAsync(bill);
                return CreatedAtAction(nameof(GetBillById), new { id = bill.IdBill }, bill);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(string id, [FromBody] Bills bill)
        {
            try
            {
                //GetProductById(id);
                if (id != bill.IdBill)
                    return BadRequest();
                await _billRepository.UpdateAsync(bill);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            try
            {
                await _billRepository.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }


    }
}
