using AspireBlob.ApiService.Models;
using Azure.Data.Tables;


namespace AspireBlob.ApiService
{
    public class BlobStorageService
    {
        private readonly TableServiceClient _tableServiceClient;
        private readonly TableClient _tableClient;


        public BlobStorageService(TableServiceClient tableServiceClient)
        {
            _tableServiceClient = tableServiceClient;
            _tableClient = _tableServiceClient.GetTableClient("DemoAccount");
            _tableClient.CreateIfNotExists();
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            // Insert data in azure table storage

            // Create a new container

            var containerClient = await _tableClient.AddEntityAsync<CustomerEntity>(new CustomerEntity
            {
                PartitionKey = "Customer1",
                RowKey = Guid.NewGuid().ToString(),
                Name = customer.Name,
                Email = customer.Email,
            });

        }

        public async Task<CustomerEntity?> GetCustomerAsync(string partitionKey, string rowKey)
        {
            return await _tableClient.GetEntityAsync<CustomerEntity>(partitionKey, rowKey);
        }


        public async Task<IEnumerable<CustomerEntity>> GetAllCustomersAsync()
        {
            List<CustomerEntity> customers = new();
            await foreach (var entity in _tableClient.QueryAsync<CustomerEntity>())
            {
                customers.Add(entity);
            }
            return customers;
        }
    }
}
