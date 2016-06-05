using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using aspnetcoreapp.models;

namespace aspnetcoreapp.controllers
{	
	[Route("api/[controller]")]
    public class ProductsController : Controller
    {        
        [HttpGet]
        public ObjectResult Get()
        {
            var products = new List<Product>(){
            	new Product(){
            		Id=1221, Name="aaa", Price=120.00
            	},
            	new Product(){
            		Id=1222, Name="vvv", Price=122.00
            	},
            	new Product(){
            		Id=1223, Name="nnn", Price=123.00
            	}
            };
            return Ok(products);
        }
        
        [HttpGet("{id:int}")]
        public ObjectResult Get(int id)
        {
            return Ok(new Product(){
            		Id=id, Name="zzz", Price=124.00
            	});
        }
    }
}
