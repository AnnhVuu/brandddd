using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_ReactApp.Server.Models;
using Shop_ReactApp.Server.Reponsitory;

namespace Shop_ReactApp.Server.Controllers
{
    [Route("api/Brand")]
    [ApiController]
    public class BrandAPIController : ControllerBase
    {
        DataWeb db;
        private readonly IBrandReponsitory _BrandRepository;
        public BrandAPIController(IBrandReponsitory BrandRepository)
        {
            _BrandRepository = BrandRepository;
        }
        [HttpGet]

        public async Task<IActionResult> GetBrands()
        {
            try
            {
                var brand = await _BrandRepository.GetAllAsync();
                return Ok(brand);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Lỗi server");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(string id)
        {
            try
            {
                var brand = await _BrandRepository.GetByIdAsync(id);
                if (brand == null)
                    return NotFound();
                return Ok(brand);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }



        [HttpPost]
        [Route("addBrand")]
        public async Task<IActionResult> AddBrand([FromBody] Brands Brand)
        {
            try
            {
                await _BrandRepository.AddAsync(Brand);
                return CreatedAtAction(nameof(GetBrandById), new { id = Brand.IdBrand }, Brand);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Updatebrand(string id, [FromBody] Brands Brand)
        {
            try
            {
                //GetbrandById(id);
                if (id != Brand.IdBrand)
                    return BadRequest();
                await _BrandRepository.UpdateAsync(Brand);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletebrand(string id)
        {
            try
            {
                await _BrandRepository.DeleteAsync(id);
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
