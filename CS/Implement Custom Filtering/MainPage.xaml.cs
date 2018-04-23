using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace Implement_Custom_Filtering {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = new object[] { "A", "B", "C", "D", "E", "F", "G", "H" };
        }
        private void grid_CustomRowFilter(object sender, RowFilterEventArgs e) {
            if(chkHideOdd.IsChecked.Value && e.ListSourceRowIndex % 2 == 1)
                e.Visible = false;
            if(chkHideEven.IsChecked.Value && e.ListSourceRowIndex % 2 == 0)
                e.Visible = false;
            e.Handled = !e.Visible ? true : false;
        }

        private void chk_CheckedOrUnchecked(object sender, RoutedEventArgs e) {
            grid.RefreshData();
        }
    }
}
