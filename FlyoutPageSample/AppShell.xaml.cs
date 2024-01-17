namespace FlyoutPageSample
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
		}

		private void Button_Clicked(System.Object sender, System.EventArgs e)
		{
			(sender as Button).HeightRequest += 50;
		}
	}
}
