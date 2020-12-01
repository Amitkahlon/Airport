﻿using Airport_Common.Models;
using AirportClient.Views;
using ChatClient.Services;
using ChatClient.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportClient.ViewModels
{
    public class StationViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;
        private readonly PlaneViewModel planeViewModel;

        public Station Station { get; set; }
        public AirportStatus Airport{ get; set; }
        public RelayCommand<Plane> ViewPlaneCommand { get; set; }
        public RelayCommand GoBackCommand { get; set; }

        public StationViewModel(NavigationService navigationService, PlaneViewModel planeViewModel)
        {
            ViewPlaneCommand = new RelayCommand<Plane>(plane => ViewPlane(plane));
            this.navigationService = navigationService;
            this.planeViewModel = planeViewModel;
            this.GoBackCommand = new RelayCommand(GoBack);
        }

        private void GoBack()
        {
            this.navigationService.ChangeContent(new AirportView());
        }

        private void ViewPlane(Plane plane)
        {
            this.planeViewModel.SetProperties(plane, Station, Airport);
            this.navigationService.ChangeContent(new PlaneView());
        }

        public void SetProperties(Station station, AirportStatus airport)
        {
            this.Station = station;
            this.Airport = airport;
        }
    }
}
