using MauiPopup;
using MauiPopup.Views;
using System.Collections;
using System.Linq;

namespace CAD_PROYECTO2.Controles;

public partial class PickerControl : BasePopupPage
{
	public PickerControl(IEnumerable itemSource, DataTemplate itemTemplate, double pickerControlHeight )
	{
		InitializeComponent();

		clPickerView.ItemsSource = itemSource;
		clPickerView.ItemTemplate = itemTemplate;
		clPickerView.HeightRequest = pickerControlHeight;
	}

	private void ClPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var currenItem = e.CurrentSelection.FirstOrDefault();
		PopupAction.ClosePopup(currenItem);
	}
}