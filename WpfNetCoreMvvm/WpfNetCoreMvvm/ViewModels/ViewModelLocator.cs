﻿using ChatClient.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace WpfNetCoreMvvm.ViewModels
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel => App.ServiceProvider.GetRequiredService<MainViewModel>();
        public HomeViewModel HomeViewModel => App.ServiceProvider.GetRequiredService<HomeViewModel>();

    }
}