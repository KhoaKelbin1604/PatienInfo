﻿using System.Collections.ObjectModel;

namespace PatienInfo
{
    public partial class App : Application
    {
        public ObservableCollection<Patient> PatientList;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}