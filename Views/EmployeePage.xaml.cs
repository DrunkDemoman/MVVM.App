using MVVM.ViewModels;

namespace MVVM.Views;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
		this.BindingContext = new EmployeePageViewModel();
	}
}