﻿using HuamanS14.Models;
using HuamanS14.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuamanS14.ViewModels
{
    public class CompraViewModel : BaseViewModel
    {
        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Compra> compras;
        public List<Compra> Compras
        {
            get { return this.compras; }
            set { SetValue(ref this.compras, value); }
        }

        public ICommand SearchCommand { get; set; }

        public CompraViewModel()
        {
            SearchCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                Compras = service.GetByText(Filter);
            });
        }
    }
}
