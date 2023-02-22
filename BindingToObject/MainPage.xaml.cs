﻿using BindingToObject.Models;

namespace BindingToObject;


public partial class MainPage : ContentPage
{
    Student student { get; set; }

    public MainPage()
	{
       
        student= new Student()
        {
            Name="Roni",
                BirthDate= new DateTime(2006,2,19),
                Image="roni.jpg"
        };
        this.BindingContext = student;
        InitializeComponent();

    }

   
}

