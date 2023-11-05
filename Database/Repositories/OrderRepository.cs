﻿using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Order);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "OrderDate",
            "DiscountPrice",
            "Price",
            "SumPrice",
            "Type",
            "EmployeeId",
            "CustomerId"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
           "InternalCode",
            "Price",
            "Type",
            "EmployeeId",
            "CustomerId"
        };

        #endregion

        #region CONSTRUCTER

        public OrderRepository() { }

        #endregion


        #region FUNCTION
        public async Task<bool> ChangeTypeOrderAsync(int pId, string type)
        {
            try
            {
                // Câu lệnh cập nhật dữ liệu
                string query = $"UPDATE {_model} " +
                               "SET status = @Type " +
                               "WHERE Id = @Id";

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var parameters = new { Id = pId, Type = type };
                    var rowsAffected = await connection.ExecuteAsync(query, parameters).ConfigureAwait(false);
                    return rowsAffected > 0;
                }
            }
            catch { return false; }
        }

        public async Task<(List<OrderDto> list, int totalCount, int pageNumber)> GetAllPropertiesAsync(
                                        string? pKeyword = "", string? pSort = "Id", int? pPageNumber = 1,
                                        int? pPageSize = 10, int? pEmployeeId = null, int? pCustomerId = null)
        {
            try
            {
                List<string> filter = new List<string>();
                filter.Add($"O.IsDeleted = 0");

                List<string> searchs = new List<string>();
                if (pKeyword != "")
                {
                    foreach (string item in _seachers)
                    {
                        searchs.Add($"{item} like N'%{pKeyword}%'");
                    }
                }

                string whereEmployee = "";
                if (pEmployeeId != null)
                {
                    whereEmployee = $" and EmployeeId = {pEmployeeId} ";
                }

                string whereCustomer = "";
                if (pCustomerId != null)
                {
                    whereCustomer = $" and CustomerId = {pCustomerId} ";
                }

                string resultSearchs = searchs.Count() > 0 ? $" and ({string.Join(" or ", searchs)})" : "";

                string query = $"SELECT O.Id, IB.InternalCode, O.OrderDate, O.Price, O.DiscountPrice, O.SumPrice, " +
                                      $"E.Id as EmployeeId, E.InternalCode as EmployeeInternalCode, E.Name as EmployeeName, " +
                                      $"C.Id as CustomerId, C.Phone as CustomerPhone, C.Name as CustomerName " +
                               $"FROM ImportBill AS 0 " +
                               $"LEFT JOIN Employee AS E ON 0.EmployeeId = E.Id " +
                               $"LEFT JOIN Customer AS C ON O.CustomerId = D.Id " +
                               $"where {string.Join(" and ", filter)} {resultSearchs} {whereEmployee} {whereCustomer}" +
                               $"order by {pSort} " +
                               $"offset {(pPageNumber - 1) * pPageSize} rows " +
                               $"fetch next {pPageSize} rows only";

                string subQuery = $"SELECT COUNT(Id) FROM {_model} as O " +
                                  $"where {string.Join(" and ", filter)} {resultSearchs} {whereEmployee} {whereCustomer};";
                int totalCount = await new SqlConnection(DatabaseCommon.ConnectionString)
                                        .ExecuteScalarAsync<int>(subQuery)
                                        .ConfigureAwait(false);

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var result = await connection.QueryAsync<OrderDto>(query).ConfigureAwait(false);

                    decimal pageNumber = Math.Ceiling(totalCount / (decimal)pPageSize);

                    return (result.AsList(), totalCount, (int)pageNumber);
                }
            }
            catch (Exception ex)
            {
                return (null, 0, 0);
            }
        }

        public async Task<OrderDto> GetDetailPropertiesAsync(int pId)
        {
            try
            {
                string query = $"SELECT O.Id, IB.InternalCode, O.OrderDate, O.Price, O.DiscountPrice, O.SumPrice, " +
                                      $"E.Id as EmployeeId, E.InternalCode as EmployeeInternalCode, E.Name as EmployeeName, " +
                                      $"C.Id as CustomerId, C.Phone as CustomerPhone, C.Name as CustomerName " +
                               $"FROM ImportBill AS 0 " +
                               $"LEFT JOIN Employee AS E ON 0.EmployeeId = E.Id " +
                               $"LEFT JOIN Customer AS C ON O.CustomerId = D.Id " +
                               $"where O.Id = {pId} and O.IsDeleted = 0";

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var order = await connection.QueryFirstOrDefaultAsync<OrderDto>(query).ConfigureAwait(false);

                    if (order != null)
                    {
                        string queryDetail = $"SELECT DO.Id, DO.Quantity, DO.Price, DO.ProductId, " +
                                                $"P.InternalCode AS ProductInternalCode, P.Name AS ProductName, P.Images AS ProductImage " +
                                                $"FROM DetailOrder AS DO " +
                                                $"LEFT JOIN Product AS P ON DO.ProductId = P.Id " +
                                             $"WHERE DO.OrderId = {pId} and D0.IsDeleted = 0";

                        order.Details = (List<DetailOrderDto>?)await connection.QueryAsync<DetailOrderDto>(queryDetail).ConfigureAwait(false);
                    }

                    return order;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}