using System.Collections.ObjectModel;

namespace Lab8PatientInfo;

public partial class HikeList : ContentPage
{
	App thisApp = Microsoft.Maui.Controls.Application.Current as App;
	public HikeList()
	{
		InitializeComponent();
		collectionView.ItemsSource = thisApp.HikeList;
	}
}