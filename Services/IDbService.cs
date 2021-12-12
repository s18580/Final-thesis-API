using Final_thesis_api.Models.DictionaryModels;
using Final_thesis_api.Models;
using System.Threading.Tasks;

namespace Final_thesis_api.Services
{
    public interface IDbService
    {
        //Dictionary data
        public Task<Worksite> AddWorksite(string name);
        public Task<Worksite> UpdateWorksite(Worksite worksite);
        public Task<bool> DeleteWorksite(int id);

        public Task<FileType> AddFileType(string name);
        public Task<FileType> UpdateFileType(FileType fileType);
        public Task<bool> DeleteFileType(int id);

        public Task<FileStatus> AddFileStatus(string name);
        public Task<FileStatus> UpdateFileStatus(FileStatus fileStatus);
        public Task<bool> DeleteFileStatus(int id);

        public Task<BindingType> AddBindingType(string name);
        public Task<BindingType> UpdateBindingType(BindingType bindingType);
        public Task<bool> DeleteBindingType(int id);
        
        public Task<OrderStatus> AddOrderStatus(string name);
        public Task<OrderStatus> UpdateOrderStatus(OrderStatus orderStatus);
        public Task<bool> DeleteOrderStatus(int id);

        public Task<SupplyItemType> AddSupplyItemType(string name);
        public Task<SupplyItemType> UpdateSupplyItemType(SupplyItemType supplyItemType);
        public Task<bool> DeleteSupplyItemType(int id);

        public Task<DeliveryType> AddDeliveryType(string name);
        public Task<DeliveryType> UpdateDeliveryType(DeliveryType deliveryType);
        public Task<bool> DeleteDeliveryType(int id);

        public Task<OrderItemType> AddOrderItemType(string name);
        public Task<OrderItemType> UpdateOrderItemType(OrderItemType orderItemType);
        public Task<bool> DeleteOrderItemType(int id);

        public Task<MinimumRate> AddMinimumRate(double price, int circulation);
        public Task<MinimumRate> UpdateMinimumRate(MinimumRate minimumRate);
        public Task<bool> DeleteMinimumRate(int id);

        public Task<ServiceName> AddServiceName(string name, double defaultPrice, int minimumRateId);
        public Task<ServiceName> UpdateServiceName(ServiceName serviceName);
        public Task<bool> DeleteServiceName(int id);
    }
}