using AutoMapper;
using ConnectionPoint.Domain;
using ConnectionPoint.Domain.Context;
using ConnectionPoint.Domain.Models;
using ConnectionPoint.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionPoint.Controllers
{
    public class CustomerController : Controller
    {
        protected IConnectionPointContext _context;
        protected IMapper _mapper;
        public CustomerController(IConnectionPointContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var result = _context.Customers.OrderByDescending(x => x.InsertDateTime)
                                           .Select(x => _mapper.Map<CustomerDTO>(x))
                                           .ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Get(long id)
        {
            var result = _context.Customers.Where(x => x.Id == id)
                                           .Select(x => _mapper.Map<CustomerDTO>(x))
                                           .SingleOrDefault()
                                           .Projects;

            return View("Detail", result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Post(CustomerDTO item)
        {

            if (ModelState.IsValid)
            {
                var itm = _mapper.Map<Customer>(item);

                await _context.Customers.AddAsync(itm);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            else return View("Add", item);

        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            //Get/x
            var result = _context.Customers.SingleOrDefault(x => x.Id == id);
            var model = _mapper.Map<CustomerDTO>(result);

            return View("Edit",model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CustomerDTO item)
        {

            if (ModelState.IsValid)
            {
                //Patch verb is used for change one entity
                var existing = _context.Customers.SingleOrDefault(x => x.Id == item.Id);

                if (existing != null)
                    _mapper.Map(item, existing, typeof(CustomerDTO), typeof(Customer));

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            else return View("Edit", item);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            //Delete verb is used for delete one entity
            var existing = _context.Customers.SingleOrDefault(x => x.Id == id);

            _context.Customers.Remove(existing);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
