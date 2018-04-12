using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace RespndingToChanges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<Personnel> Personnels = new BindingList<Personnel>();

        public MainWindow()
        {
            InitializeComponent();

            lbxPersonnel.ItemsSource = Personnels;

            btnAdd.Click -= BtnAdd_Click;
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click -= BtnDelete_Click;
            btnDelete.Click += BtnDelete_Click;
            btnEdit.Click -= BtnEdit_Click;
            btnEdit.Click += BtnEdit_Click;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbxPersonnel.SelectedItem != null)
                Personnels.Remove((Personnel)lbxPersonnel.SelectedItem);
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Personnels.Add(new Personnel() { Name = "New Personnel" });
        }
    }

    public class ObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetField<T>(ref T field, T value, string propertyName)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
        }
    }
    public class Personnel : ObjectBase
    {
        string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { SetField(ref name, value, nameof(Name)); }
        }
    }

    //public class Personnel : INotifyPropertyChanged
    //{
    //    public Personnel()
    //    {
    //    }

    //    string name = string.Empty;
    //    public string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            if (!name.Equals(value))
    //            {
    //                name = value;
    //                NotifyPropertyChanged(nameof(Name));
    //            }
    //        }
    //    }


    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void NotifyPropertyChanged( String propertyName)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}
}
