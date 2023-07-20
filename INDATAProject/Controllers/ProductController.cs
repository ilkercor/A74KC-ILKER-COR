using INDATAProject.Models;
using INDATAProject.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace INDATAProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController (IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            var product = _productRepository.GetProducts();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public ActionResult GetUsersById(int id)
        {
            var product = _productRepository.GetProductById(id);
            return Ok(product);
        }

        [HttpPost("add")]
        public ActionResult Add([FromBody] Product product)
        {
            _productRepository.Add(product);
            _productRepository.SaveAll();
            return Ok();
        }

        [HttpDelete("delete")]
        public ActionResult Delete([FromBody] Product product)
        {
            try
            {
                _productRepository.Delete(product);
                _productRepository.SaveAll();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPost("update")]
        public ActionResult Update([FromBody] Product product)
        {
            try
            {
                _productRepository.Update(product);
                _productRepository.SaveAll();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
