﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Students_MVVM;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    private ViewModel viewModel = new ViewModel();
    public MainWindow()
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    void addNewStudent(object sender, EventArgs e)
    {
        var addStudent = new Students_MVVM.View.AddStudent();
        addStudent.Show();
    }
}