using Final_thesis_api.Models.DictionaryModels;
using Final_thesis_api.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Final_thesis_api.Models.DTOs;

namespace Final_thesis_api.Services
{
    public interface IDbService
    {
        #region DTOs
        public Task<UserData> GetUserLoginData(string email);
        #endregion

        #region Main models
        public Task<IEnumerable<RoleAssignment>> GetAllRoleAssignments();
        public Task<RoleAssignment> GetRoleAssignment(int idWorker, int idRole);
        public Task<IEnumerable<RoleAssignment>> GetRolesAssignmentByWorker(int id);
        public Task<IEnumerable<RoleAssignment>> GetRolesAssignmentByRole(int id);
        public Task<RoleAssignment> AddRoleAssignment(RoleAssignment roleAssignment);
        public Task<RoleAssignment> UpdateRoleAssignment(RoleAssignment roleAssignment);
        public Task<bool> DeleteRoleAssignment(int idWorker, int idRole);
        public Task<bool> DeleteRoleAssignment(RoleAssignment roleAssignment);
        public Task<bool> DeleteRoleAssignments(IEnumerable<RoleAssignment> roleAssignment);

        public Task<IEnumerable<ValuationPriceList>> GetAllValuationPriceLists();
        public Task<ValuationPriceList> GetValuationPriceList(int idValutaion, int idPriceList);
        public Task<IEnumerable<ValuationPriceList>> GetValuationPriceListByValuation(int idValutaion);
        public Task<IEnumerable<ValuationPriceList>> GetValuationPriceListByPriceList(int idPriceList);
        public Task<ValuationPriceList> AddValuationPriceList(ValuationPriceList valuationPriceList);
        public Task<ValuationPriceList> UpdateValuationPriceList(ValuationPriceList valuationPriceList);
        public Task<bool> DeleteValuationPriceList(int idValutaion, int idPriceList);

        public Task<IEnumerable<DeliveriesAddresses>> GetAllDeliveriesAddresses();
        public Task<DeliveriesAddresses> GetDeliveriesAddresses(int idAddress, int idLink);
        public Task<IEnumerable<DeliveriesAddresses>> GetDeliveriesAddressesByAddress(int idAddress);
        public Task<IEnumerable<DeliveriesAddresses>> GetDeliveriesAddressesByLink(int idLink);
        public Task<DeliveriesAddresses> AddDeliveriesAddresses();
        public Task<DeliveriesAddresses> UpdateDeliveriesAddresses();
        public Task<bool> DeleteDeliveriesAddresses(int idAddress, int idLink);

        public Task<IEnumerable<Assignment>> GetAllAssignments();
        public Task<Assignment> GetAssignment(int idWorker, int idOrder);
        public Task<IEnumerable<Assignment>> GetAssignmentsByWorker(int id);
        public Task<IEnumerable<Assignment>> GetAssignmentsByOrder(int id);
        public Task<Assignment> AddAssignment(Assignment assignment);
        public Task<Assignment> UpdateAssignment(Assignment assignment);
        public Task<bool> DeleteAssignment(int idWorker, int idOrder);

        public Task<IEnumerable<Service>> GetAllServices();
        public Task<Service> GetService(int id);
        public Task<Service> AddService(Service service);
        public Task<Service> UpdateService(Service service);
        public Task<bool> DeleteService(int id);

        public Task<IEnumerable<Paper>> GetAllPapers();
        public Task<Paper> GetPaper(int id);
        public Task<Paper> AddPaper(Paper paper);
        public Task<Paper> UpdatePaper(Paper paper);
        public Task<bool> DeletePaper(int id);

        public Task<IEnumerable<Color>> GetAllColors();
        public Task<Color> GetColor(int id);
        public Task<Color> AddColor(Color color);
        public Task<Color> UpdateColor(Color color);
        public Task<bool> DeleteColor(int id);

        public Task<IEnumerable<Representative>> GetAllRepresentatives();
        public Task<Representative> GetRepresentative(int id);
        public Task<Representative> AddRepresentative(Representative representative);
        public Task<Representative> UpdateRepresentative(Representative representative);
        public Task<bool> DeleteRepresentative(int id);

        public Task<IEnumerable<OrderItem>> GetAllOrderItems();
        public Task<OrderItem> GetOrderItem(int id);
        public Task<OrderItem> AddOrderItem(OrderItem orderItem);
        public Task<OrderItem> UpdateOrderItem(OrderItem orderItem);
        public Task<bool> DeleteOrderItem(int id);

        public Task<IEnumerable<Supply>> GetAllSupplies();
        public Task<Supply> GetSupply(int id);
        public Task<Supply> AddSupply(Supply supply);
        public Task<Supply> UpdateSupply(Supply supply);
        public Task<bool> DeleteSupply(int id);

        public Task<IEnumerable<Address>> GetAllAddresses();
        public Task<Address> GetAddress(int id);
        public Task<Address> AddAddress(Address address);
        public Task<Address> UpdateAddress(Address address);
        public Task<bool> DeleteAddress(int id);

        public Task<IEnumerable<Order>> GetAllOrders();
        public Task<Order> GetOrder(int id);
        public Task<Order> AddOrder(Order order);
        public Task<Order> UpdateOrder(Order order);
        public Task<bool> DeleteOrder(int id);

        public Task<IEnumerable<File>> GetAllFiles();
        public Task<File> GetFile(int id);
        public Task<File> AddFile(File file);
        public Task<File> UpdateFile(File file);
        public Task<bool> DeleteFile(int id);

        public Task<IEnumerable<Valuation>> GetAllValuations();
        public Task<Valuation> GetValuation(int id);
        public Task<Valuation> AddValuation(Valuation valuation);
        public Task<Valuation> UpdateValuation(Valuation valuation);
        public Task<bool> DeleteValuation(int id);

        public Task<IEnumerable<Worker>> GetAllWorkers();
        public Task<Worker> GetWorker(int id);
        public Task<Worker> AddWorker(Worker worker);
        public Task<Worker> UpdateWorker(Worker worker);
        public Task<bool> DisableWorker(int id);
        public Task<bool> DeleteWorker(int id);

        public Task<IEnumerable<Customer>> GetAllCustomers();
        public Task<Customer> GetCustomer(int id);
        public Task<Customer> AddCustomer(Customer customer);
        public Task<Customer> UpdateCustomer(Customer customer);
        public Task<bool> DeleteCustomer(int id);

        public Task<IEnumerable<Supplier>> GetAllSuppliers();
        public Task<Supplier> GetSuppliers(int id);
        public Task<Supplier> AddSupplier(Supplier supplier);
        public Task<Supplier> UpdateSupplier(Supplier supplier);
        public Task<bool> DeleteSupplier(int id);
        #endregion

        #region Dictionary models
        public Task<IEnumerable<Worksite>> GetAllWorksites();
        public Task<Worksite> GetWorksite(int id);
        public Task<Worksite> AddWorksite(Worksite worksite);
        public Task<Worksite> UpdateWorksite(Worksite worksite);
        public Task<bool> DeleteWorksite(int id);

        public Task<IEnumerable<FileType>> GetAllFileTypes();
        public Task<FileType> GetFileType(int id);
        public Task<FileType> AddFileType(FileType fileType);
        public Task<FileType> UpdateFileType(FileType fileType);
        public Task<bool> DeleteFileType(int id);

        public Task<IEnumerable<FileStatus>> GetAllFileStatuses();
        public Task<FileStatus> GetFileStatus(int id);
        public Task<FileStatus> AddFileStatus(FileStatus fileStatus);
        public Task<FileStatus> UpdateFileStatus(FileStatus fileStatus);
        public Task<bool> DeleteFileStatus(int id);

        public Task<IEnumerable<BindingType>> GetAllBindingTypes();
        public Task<BindingType> GetBindingType(int id);
        public Task<BindingType> AddBindingType(BindingType bindingType);
        public Task<BindingType> UpdateBindingType(BindingType bindingType);
        public Task<bool> DeleteBindingType(int id);

        public Task<IEnumerable<OrderStatus>> GetAllOrderStatuses();
        public Task<OrderStatus> GetOrderStatus(int id);
        public Task<OrderStatus> AddOrderStatus(OrderStatus orderStatus);
        public Task<OrderStatus> UpdateOrderStatus(OrderStatus orderStatus);
        public Task<bool> DeleteOrderStatus(int id);

        public Task<IEnumerable<SupplyItemType>> GetAllSupplyItemTypes();
        public Task<SupplyItemType> GetSupplyItemType(int id);
        public Task<SupplyItemType> AddSupplyItemType(SupplyItemType supplyItemType);
        public Task<SupplyItemType> UpdateSupplyItemType(SupplyItemType supplyItemType);
        public Task<bool> DeleteSupplyItemType(int id);

        public Task<IEnumerable<DeliveryType>> GetAllDeliveryTypes();
        public Task<DeliveryType> GetDeliveryType(int id);
        public Task<DeliveryType> AddDeliveryType(DeliveryType deliveryType);
        public Task<DeliveryType> UpdateDeliveryType(DeliveryType deliveryType);
        public Task<bool> DeleteDeliveryType(int id);

        public Task<IEnumerable<OrderItemType>> GetAllOrderItemTypes();
        public Task<OrderItemType> GetOrderItemType(int id);
        public Task<OrderItemType> AddOrderItemType(OrderItemType orderItemType);
        public Task<OrderItemType> UpdateOrderItemType(OrderItemType orderItemType);
        public Task<bool> DeleteOrderItemType(int id);

        public Task<IEnumerable<MinimumRate>> GetAllMinimumRates();
        public Task<MinimumRate> GetMinimumRate(int id);
        public Task<MinimumRate> AddMinimumRate(MinimumRate minimumRate);
        public Task<MinimumRate> UpdateMinimumRate(MinimumRate minimumRate);
        public Task<bool> DeleteMinimumRate(int id);

        public Task<IEnumerable<ServiceName>> GetAllServiceNames();
        public Task<ServiceName> GetServiceName(int id);
        public Task<ServiceName> AddServiceName(ServiceName serviceName);
        public Task<ServiceName> UpdateServiceName(ServiceName serviceName);
        public Task<bool> DeleteServiceName(int id);

        public Task<IEnumerable<PriceList>> GetAllPriceList();
        public Task<PriceList> GetPriceList(int id);
        public Task<PriceList> AddPriceList(PriceList priceList);
        public Task<PriceList> UpdatePriceList(PriceList serviceName);
        public Task<bool> DeletePriceList(int id);

        public Task<IEnumerable<Role>> GetAllRoles();
        public Task<IEnumerable<Role>> GetAllUserRoles(int id);
        #endregion
    }
}