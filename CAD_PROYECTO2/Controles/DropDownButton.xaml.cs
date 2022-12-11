using MauiPopup;
using System.Collections;

namespace CAD_PROYECTO2.Controles;

public partial class DropDownButton : Frame
{
	public DropDownButton()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty ItemSourceProperty = BindableProperty.Create(
		propertyName: nameof(ItemSource),
		returnType: typeof(IEnumerable),
		declaringType: typeof(DropDownButton),
		defaultBindingMode: BindingMode.OneWay);

	public IEnumerable ItemSource
	{
		get=> (IEnumerable)GetValue(ItemSourceProperty);
		set => SetValue(ItemSourceProperty, value);
	}

	public DataTemplate ItemTemplate { get; set; }

	public double height { get; set;  }

	public string DisplayName { get; set; }

	private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		var response = await PopupAction.DisplayPopup<object>(new PickerControl(ItemSource, ItemTemplate, height));
		if(response != null)
		{
			if(!string.IsNullOrWhiteSpace(DisplayName))
				lblDroop.Text = response.GetType().GetProperty(DisplayName).GetValue(response,null).ToString();
		}
	}

}