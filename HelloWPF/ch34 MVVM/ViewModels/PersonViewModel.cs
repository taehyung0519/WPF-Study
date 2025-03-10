﻿using ch34_MVVM.Commands;
using ch34_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ch34_MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonCommand PersonCommand { get; set; }
       public List<PersonModel> PersonList { get; set; }
        public PersonViewModel()
        {
            PersonList = new List<PersonModel>
            {
                new PersonModel{ Name="홍길동",Age=100},
                new PersonModel{ Name="임꺽정",Age=90},
                new PersonModel{ Name="타요",Age=10},
                new PersonModel{ Name="뽀로로",Age=12},
                new PersonModel{ Name="폴리",Age=7},
            };
            PersonCommand = new PersonCommand(Msg,CheckMsg);
      
    
    
        }
        protected void Msg(string txt)
        {
            MessageBox.Show(txt);
        }
        public bool CheckMsg(string txt)
        {
            if(txt.Length > 0) { return true; }
            else { return false; }
        }

  
      
    }
}
