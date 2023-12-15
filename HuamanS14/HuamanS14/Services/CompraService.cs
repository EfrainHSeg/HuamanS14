using HuamanS14.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HuamanS14.Services
{
    public class CompraService
    {
        private readonly DataContext.AppDbContext _context;
        public CompraService() => _context = App.GetContext();

        public bool Create(Compra item)
        {
            try
            {
                _context.Compra.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }

        public bool CreateRange(List<Compra> items)
        {
            try
            {
                _context.Compra.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<Compra> Get()
        {
            return _context.Compra.ToList();
        }
        public List<Compra> GetByText(string text)
        {
            return _context.Compra.Where(x => x.Cliente.Contains(text)).ToList();
        }
    }

}
