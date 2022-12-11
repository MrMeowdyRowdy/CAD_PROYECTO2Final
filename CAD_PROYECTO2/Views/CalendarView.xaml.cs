using CAD_PROYECTO2.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CAD_PROYECTO2.Views;

public partial class CalendarView : StackLayout
{
	#region BindableProperty
	public static readonly BindableProperty SelectDateProperty = BindableProperty.Create
		(
		nameof(SelectedDate),
		typeof(DateTime),
		declaringType: typeof(CalendarView),
		defaultBindingMode: BindingMode.TwoWay,
		defaultValue: DateTime.Now
		);

	public DateTime SelectedDate
	{
		get => (DateTime)GetValue(SelectDateProperty);
		set => SetValue(SelectDateProperty, value);	
	}

	#endregion
    public ObservableCollection<Calendar> Dates { get; set; } = new ObservableCollection<Calendar>();
	
	public CalendarView()
	{
		InitializeComponent();
		BinDates(DateTime.Now);
	}

	private void BinDates(DateTime selectedDate)
	{
		int daysCount = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
		for(int day = 1; day <= daysCount; day++)
		{
			Dates.Add(new Calendar
			{
				Date = new DateTime(selectedDate.Year, selectedDate.Month, day) 
			});
			
		}
		Dates.Where(f => f.Date.Date == selectedDate.Date).FirstOrDefault().IsCurrentDate = true;
	}

	#region Commands
	public ICommand CurrenDataCommand => new Command<Calendar>((currenDate) =>
	{ 
		SelectedDate = currenDate.Date;
		Dates.ToList().ForEach(f => f.IsCurrentDate = false);
		currenDate.IsCurrentDate = true;

    });
    #endregion
}