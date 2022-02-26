using Final_thesis_api.Models;
using Final_thesis_api.Models.DictionaryModels;
using Microsoft.EntityFrameworkCore;
using Final_thesis_api.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Final_thesis_api.Services
{
    public class SqlDbService : IDbService
    {

        private readonly ModelContext _context;

        public SqlDbService(ModelContext context)
        {
            _context = context;
        }

        private bool IsStringValid(string target, int maxLength, bool isRequired, string pattern = "")
        {
            if (target.Length >= maxLength || (string.IsNullOrEmpty(target) && isRequired))
            {
                return false;
            }

            if (pattern != "")
            {
                return Regex.IsMatch(target, pattern);
            }

            return true;
        }

        #region DTOs
        public Task<UserData> GetUserLoginData(string email)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Main models
        public Task<IEnumerable<RoleAssignment>> GetAllRoleAssignments()
        {
            throw new NotImplementedException();
        }
        public Task<RoleAssignment> GetRoleAssignment(int idWorker, int idRole)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<RoleAssignment>> GetRolesAssignmentByWorker(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<RoleAssignment>> GetRolesAssignmentByRole(int id)
        {
            throw new NotImplementedException();
        }
        public Task<RoleAssignment> AddRoleAssignment(RoleAssignment roleAssignment)
        {
            throw new NotImplementedException();
        }
        public Task<RoleAssignment> UpdateRoleAssignment(RoleAssignment roleAssignment)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteRoleAssignment(int idWorker, int idRole)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteRoleAssignment(RoleAssignment roleAssignment)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteRoleAssignments(IEnumerable<RoleAssignment> roleAssignment)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ValuationPriceList>> GetAllValuationPriceLists()
        {
            throw new NotImplementedException();
        }
        public Task<ValuationPriceList> GetValuationPriceList(int idValutaion, int idPriceList)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<ValuationPriceList>> GetValuationPriceListByValuation(int idValutaion)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<ValuationPriceList>> GetValuationPriceListByPriceList(int idPriceList)
        {
            throw new NotImplementedException();
        }
        public Task<ValuationPriceList> AddValuationPriceList(ValuationPriceList valuationPriceList)
        {
            throw new NotImplementedException();
        }
        public Task<ValuationPriceList> UpdateValuationPriceList(ValuationPriceList valuationPriceList)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteValuationPriceList(int idValutaion, int idPriceList)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DeliveriesAddresses>> GetAllDeliveriesAddresses()
        {
            throw new NotImplementedException();
        }
        public Task<DeliveriesAddresses> GetDeliveriesAddresses(int idAddress, int idLink)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<DeliveriesAddresses>> GetDeliveriesAddressesByAddress(int idAddress)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<DeliveriesAddresses>> GetDeliveriesAddressesByLink(int idLink)
        {
            throw new NotImplementedException();
        }
        public Task<DeliveriesAddresses> AddDeliveriesAddresses()
        {
            throw new NotImplementedException();
        }
        public Task<DeliveriesAddresses> UpdateDeliveriesAddresses()
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteDeliveriesAddresses(int idAddress, int idLink)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Assignment>> GetAllAssignments()
        {
            throw new NotImplementedException();
        }
        public Task<Assignment> GetAssignment(int idWorker, int idOrder)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Assignment>> GetAssignmentsByWorker(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Assignment>> GetAssignmentsByOrder(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Assignment> AddAssignment(Assignment assignment)
        {
            throw new NotImplementedException();
        }
        public Task<Assignment> UpdateAssignment(Assignment assignment)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteAssignment(int idWorker, int idOrder)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Service>> GetAllServices()
        {
            throw new NotImplementedException();
        }
        public Task<Service> GetService(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Service> AddService(Service service)
        {
            throw new NotImplementedException();
        }
        public Task<Service> UpdateService(Service service)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteService(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Paper>> GetAllPapers()
        {
            throw new NotImplementedException();
        }
        public Task<Paper> GetPaper(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Paper> AddPaper(Paper paper)
        {
            throw new NotImplementedException();
        }
        public Task<Paper> UpdatePaper(Paper paper)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeletePaper(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Color>> GetAllColors()
        {
            throw new NotImplementedException();
        }
        public Task<Color> GetColor(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Color> AddColor(Color color)
        {
            throw new NotImplementedException();
        }
        public Task<Color> UpdateColor(Color color)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteColor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Representative>> GetAllRepresentatives()
        {
            throw new NotImplementedException();
        }
        public Task<Representative> GetRepresentative(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Representative> AddRepresentative(Representative representative)
        {
            throw new NotImplementedException();
        }
        public Task<Representative> UpdateRepresentative(Representative representative)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteRepresentative(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetAllOrderItems()
        {
            throw new NotImplementedException();
        }
        public Task<OrderItem> GetOrderItem(int id)
        {
            throw new NotImplementedException();
        }
        public Task<OrderItem> AddOrderItem(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
        public Task<OrderItem> UpdateOrderItem(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteOrderItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supply>> GetAllSupplies()
        {
            throw new NotImplementedException();
        }
        public Task<Supply> GetSupply(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Supply> AddSupply(Supply supply)
        {
            throw new NotImplementedException();
        }
        public Task<Supply> UpdateSupply(Supply supply)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteSupply(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAllAddresses()
        {
            throw new NotImplementedException();
        }
        public Task<Address> GetAddress(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Address> AddAddress(Address address)
        {
            throw new NotImplementedException();
        }
        public Task<Address> UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }
        public Task<Order> GetOrder(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Order> AddOrder(Order order)
        {
            throw new NotImplementedException();
        }
        public Task<Order> UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<File>> GetAllFiles()
        {
            throw new NotImplementedException();
        }
        public Task<File> GetFile(int id)
        {
            throw new NotImplementedException();
        }
        public Task<File> AddFile(File file)
        {
            throw new NotImplementedException();
        }
        public Task<File> UpdateFile(File file)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteFile(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Valuation>> GetAllValuations()
        {
            throw new NotImplementedException();
        }
        public Task<Valuation> GetValuation(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Valuation> AddValuation(Valuation valuation)
        {
            throw new NotImplementedException();
        }
        public Task<Valuation> UpdateValuation(Valuation valuation)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteValuation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Worker>> GetAllWorkers()
        {
            return await _context.Workers
                                 .ToListAsync();
        }
        public async Task<Worker> GetWorker(int id)
        {
            return await _context.Workers
                                 .Where(p => p.IdWorker == id)
                                 .SingleAsync();
        }
        public async Task<Worker> AddWorker(Worker worker)
        {
            await _context.Workers.AddAsync(worker);
            await _context.SaveChangesAsync();

            return worker;
        }
        public async Task<Worker> UpdateWorker(Worker worker)
        {
            var updatedWorker = await GetWorker(worker.IdWorker);

            if (!string.Equals(updatedWorker.Name, worker.Name) && IsStringValid(worker.Name, 32, true)) updatedWorker.Name = worker.Name;
            if (!string.Equals(updatedWorker.LastName, worker.LastName) && IsStringValid(worker.LastName, 64, true)) updatedWorker.LastName = worker.LastName;
            if (!string.Equals(updatedWorker.PhoneNumber, worker.PhoneNumber) && IsStringValid(worker.PhoneNumber, 32, false)) updatedWorker.PhoneNumber = worker.PhoneNumber; // add regex for phones
            if (!string.Equals(updatedWorker.EmailAddres, worker.EmailAddres) && IsStringValid(worker.EmailAddres, 255, true, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) updatedWorker.EmailAddres = worker.EmailAddres;

            await _context.SaveChangesAsync();

            return updatedWorker;
        }
        public async Task<bool> DisableWorker(int id)
        {
            var worker = await GetWorker(id);
            worker.IsDisabled = true;
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<bool> DeleteWorker(int id)
        {
            var worker = await GetWorker(id);
            if (!worker.IsDisabled)
            {
                throw new Exception("Cannot delete not disabled worker.");
            }

            worker.PhoneNumber = null;
            worker.EmailAddres = null;
            worker.PassHash = null;

            var roleAssignments = await GetRolesAssignmentByWorker(worker.IdWorker);
            await DeleteRoleAssignments(roleAssignments);
            await _context.SaveChangesAsync();

            return true;
        }

        public Task<IEnumerable<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }
        public Task<Customer> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Customer> AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
        public Task<Customer> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supplier>> GetAllSuppliers()
        {
            throw new NotImplementedException();
        }
        public Task<Supplier> GetSuppliers(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Supplier> AddSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }
        public Task<Supplier> UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteSupplier(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Dictionary models
        public Task<IEnumerable<Worksite>> GetAllWorksites()
        {
            throw new NotImplementedException();
        }
        public Task<Worksite> GetWorksite(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Worksite> AddWorksite(Worksite worksite)
        {
            throw new NotImplementedException();
        }
        public Task<Worksite> UpdateWorksite(Worksite worksite)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteWorksite(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileType>> GetAllFileTypes()
        {
            throw new NotImplementedException();
        }
        public Task<FileType> GetFileType(int id)
        {
            throw new NotImplementedException();
        }
        public Task<FileType> AddFileType(FileType fileType)
        {
            throw new NotImplementedException();
        }
        public Task<FileType> UpdateFileType(FileType fileType)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteFileType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileStatus>> GetAllFileStatuses()
        {
            throw new NotImplementedException();
        }
        public Task<FileStatus> GetFileStatus(int id)
        {
            throw new NotImplementedException();
        }
        public Task<FileStatus> AddFileStatus(FileStatus fileStatus)
        {
            throw new NotImplementedException();
        }
        public Task<FileStatus> UpdateFileStatus(FileStatus fileStatus)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteFileStatus(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BindingType>> GetAllBindingTypes()
        {
            throw new NotImplementedException();
        }
        public Task<BindingType> GetBindingType(int id)
        {
            throw new NotImplementedException();
        }
        public Task<BindingType> AddBindingType(BindingType bindingType)
        {
            throw new NotImplementedException();
        }
        public Task<BindingType> UpdateBindingType(BindingType bindingType)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteBindingType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderStatus>> GetAllOrderStatuses()
        {
            throw new NotImplementedException();
        }
        public Task<OrderStatus> GetOrderStatus(int id)
        {
            throw new NotImplementedException();
        }
        public Task<OrderStatus> AddOrderStatus(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
        public Task<OrderStatus> UpdateOrderStatus(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteOrderStatus(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SupplyItemType>> GetAllSupplyItemTypes()
        {
            throw new NotImplementedException();
        }
        public Task<SupplyItemType> GetSupplyItemType(int id)
        {
            throw new NotImplementedException();
        }
        public Task<SupplyItemType> AddSupplyItemType(SupplyItemType supplyItemType)
        {
            throw new NotImplementedException();
        }
        public Task<SupplyItemType> UpdateSupplyItemType(SupplyItemType supplyItemType)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteSupplyItemType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DeliveryType>> GetAllDeliveryTypes()
        {
            throw new NotImplementedException();
        }
        public Task<DeliveryType> GetDeliveryType(int id)
        {
            throw new NotImplementedException();
        }
        public Task<DeliveryType> AddDeliveryType(DeliveryType deliveryType)
        {
            throw new NotImplementedException();
        }
        public Task<DeliveryType> UpdateDeliveryType(DeliveryType deliveryType)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteDeliveryType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItemType>> GetAllOrderItemTypes()
        {
            throw new NotImplementedException();
        }
        public Task<OrderItemType> GetOrderItemType(int id)
        {
            throw new NotImplementedException();
        }
        public Task<OrderItemType> AddOrderItemType(OrderItemType orderItemType)
        {
            throw new NotImplementedException();
        }
        public Task<OrderItemType> UpdateOrderItemType(OrderItemType orderItemType)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteOrderItemType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MinimumRate>> GetAllMinimumRates()
        {
            throw new NotImplementedException();
        }
        public Task<MinimumRate> GetMinimumRate(int id)
        {
            throw new NotImplementedException();
        }
        public Task<MinimumRate> AddMinimumRate(MinimumRate minimumRate)
        {
            throw new NotImplementedException();
        }
        public Task<MinimumRate> UpdateMinimumRate(MinimumRate minimumRate)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteMinimumRate(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ServiceName>> GetAllServiceNames()
        {
            throw new NotImplementedException();
        }
        public Task<ServiceName> GetServiceName(int id)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceName> AddServiceName(ServiceName serviceName)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceName> UpdateServiceName(ServiceName serviceName)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteServiceName(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PriceList>> GetAllPriceList()
        {
            throw new NotImplementedException();
        }
        public Task<PriceList> GetPriceList(int id)
        {
            throw new NotImplementedException();
        }
        public Task<PriceList> AddPriceList(PriceList priceList)
        {
            throw new NotImplementedException();
        }
        public Task<PriceList> UpdatePriceList(PriceList serviceName)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeletePriceList(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetAllRoles()
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Role>> GetAllUserRoles(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
