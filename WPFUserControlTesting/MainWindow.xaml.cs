using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFUserControlTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainWindowViewModel
            {
                ColumnText = "FromMainWindow",
                Value = "<3333"
            };
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Apple", Value = 50 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Banana", Value = 70 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Cat", Value = 30 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Dog", Value = 80 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Apple", Value = 50 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Banana", Value = 70 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Cat", Value = 30 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Dog", Value = 80 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Apple", Value = 50 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Banana", Value = 70 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Cat", Value = 30 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Dog", Value = 80 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Apple", Value = 50 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Banana", Value = 70 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Cat", Value = 30 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Dog", Value = 80 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Apple", Value = 50 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Banana", Value = 70 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Cat", Value = 30 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Dog", Value = 80 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Apple", Value = 50 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Banana", Value = 70 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Cat", Value = 30 });
            vm.ChartBarRecordList.Add(new ChartBarRecord { ColumnName = "Dog", Value = 80 });
            foreach (var a in vm.ChartBarRecordList)
            {
                a.ParentList = vm.ChartBarRecordList;
            }
            this.DataContext = vm;            

        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public string ColumnText { get; set; }
        public string Value { get; set; }

        public void InformPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        }

        public NathanDataGrid<ChartBarRecord> ChartBarRecordList { get; set; } = new NathanDataGrid<ChartBarRecord>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
