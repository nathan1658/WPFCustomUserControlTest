using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for TestUserControl.xaml
    /// </summary>
    public partial class TestUserControl : UserControl
    {


        #region DP



        public string LabelString
        {
            get { return (string)GetValue(LabelStringProperty); }
            set { SetValue(LabelStringProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelString.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelStringProperty =
            DependencyProperty.Register("LabelString", typeof(string), typeof(TestUserControl));



        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(TestUserControl));




        public IList<ChartBarRecord> DataGridItems
        {
            get { return (IList<ChartBarRecord>)GetValue(DataGridItemsProperty); }
            set { SetValue(DataGridItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DataGridItems.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DataGridItemsProperty =
            DependencyProperty.Register("DataGridItems", typeof(IList<ChartBarRecord>), typeof(TestUserControl));





        #endregion
        public TestUserControl()
        {
            InitializeComponent();
            this.LayoutGrid.DataContext = this;
        }
    }


    public class TestUserControlViewModel:BaseModel
    {
        public string LabelString { get; set; } = "DESIGN";
        public string Value { get; set; } = "TIME";
        public NathanDataGrid<ChartBarRecord> DataGridItems { get; set; } = new NathanDataGrid<ChartBarRecord>();
        public TestUserControlViewModel()
        {
            
            DataGridItems.Add(new ChartBarRecord { ColumnName = "Apple", Value = 50 });
            DataGridItems.Add(new ChartBarRecord { ColumnName = "Banana", Value = 70 });
            DataGridItems.Add(new ChartBarRecord { ColumnName = "Cat", Value = 30 });            
            DataGridItems.Add(new ChartBarRecord { ColumnName = "Dog", Value = 80 });
            foreach(var a in DataGridItems)
            {
                a.ParentList = DataGridItems;
            }
            InformPropertyChanged("DataGridItems");
        }

    }

    public class NathanDataGrid<T>:ObservableCollection<T>
    {
        public int MaxValue
        {
            get
            {                
                if(this.Items is IList<ChartBarRecord>)
                {
                    IList<ChartBarRecord> list = this.Items as IList<ChartBarRecord>;
                    return list.Max(x => x.Value);
                }
                return 0;
            }
        }       
    }

}
