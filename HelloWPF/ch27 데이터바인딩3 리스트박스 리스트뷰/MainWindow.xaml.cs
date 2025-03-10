﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ch27_데이터바인딩3_리스트박스_리스트뷰
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Person
    {
        public string 이름 { get; set; }
        public int 나이 { get; set; }
        public int 별점 { get; set; }
    }
    public partial class MainWindow : Window
    {
        List<Person> person = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            person.Add(new Person() {이름="홍길동",나이=100,별점=95 });
            person.Add(new Person() {이름="임꺽정",나이=90,별점=89 });
            person.Add(new Person() {이름="타요",나이=10,별점=85 });
            person.Add(new Person() {이름="뽀로로",나이=5,별점=80 });
            person.Add(new Person() {이름="폴리",나이=7,별점=90 });
            lb.ItemsSource = person;
            lv.ItemsSource = person;
        }
    }    
  
}
