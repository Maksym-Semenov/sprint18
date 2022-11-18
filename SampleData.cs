﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAuthenticationAuthorization.Models;

namespace TaskAuthenticationAuthorization
{
    public class SampleData
    {
        public static void Initialize(ShoppingContext context)
        {
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }
            context.Products.AddRange(
                    new Product
                    {
                        Name = "Butter",
                        Price = 30.0
                    },
                    new Product
                    {
                        Name = "Banana",
                        Price = 20.50
                    },
                    new Product
                    {
                        Name = "Cola",
                        Price = 9.30
                    }
                );
            context.SaveChanges();
            context.Customers.AddRange(
                    new Customer
                    {
                        FirstName = "Ostap",
                        LastName = "Bender",
                        Address = "Rio de Zhmerinka",
                        Discount = Discount.O,

                    },
                    new Customer
                    {
                        FirstName = "Shura",
                        LastName = "Balaganov",
                        Address = "Odessa",
                        Discount = Discount.R,

                    }
                );
            context.SaveChanges();
            context.SuperMarkets.AddRange(
                    new SuperMarket
                    {
                        Name = "Wellmart",
                        Address = "Lviv",

                    },
                    new SuperMarket
                    {
                        Name = "Billa",
                        Address = "Odessa",

                    }
                );
            context.SaveChanges();
            context.Orders.AddRange(
                    new Order
                    {
                        CustomerId = 1,
                        SuperMarketId = 1,
                        OrderDate = DateTime.Now,
                     },
                        new Order
                        {
                            CustomerId = 1,
                            SuperMarketId = 1,
                            OrderDate = DateTime.Now,
                         }
                );
            context.SaveChanges();
            context.OrderDetails.AddRange(
                    new OrderDetail
                    {
                        OrderId = 1,
                        ProductId = 1,
                        Quantity = 2

                    },
                        new OrderDetail
                        {
                            OrderId = 2,
                            ProductId = 2,
                            Quantity = 1
                        }
                );
            context.SaveChanges();
        }
    }
 }
