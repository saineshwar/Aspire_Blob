using AspireBlob.ApiService.Models;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspireBlob.ApiService
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobsController : ControllerBase
    {
        private readonly BlobStorageService _blobStorageService;

        public BlobsController(BlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            await _blobStorageService.AddCustomerAsync(customer);
            return Ok();
        }

        [HttpGet("{partitionKey}/{rowKey}")]
        public async Task<IActionResult> GetCustomer(string partitionKey, string rowKey)
        {
            var customer = await _blobStorageService.GetCustomerAsync(partitionKey, rowKey);
            if (customer == null) return NotFound();
            return Ok(customer);
        }
    }
}
