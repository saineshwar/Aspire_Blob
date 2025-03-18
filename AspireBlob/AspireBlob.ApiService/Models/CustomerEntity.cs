using Azure;
using Azure.Data.Tables;

namespace AspireBlob.ApiService.Models
{
    public class CustomerEntity :ITableEntity
    {
        public string PartitionKey { get; set; } = default!;
        public string RowKey { get; set; } = default!;
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; } = ETag.All;

        // Custom Properties
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
    }


    public class Customer
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
