namespace PAMobile.Views.Products;

public partial class EducationDetailsPage : ContentPage
{
	public EducationDetailsPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string action = await DisplayActionSheet("���������:", "������", null, "0 (555) 781 556", "0 (700) 781 556", "0 (777) 781 556");

            if (!string.IsNullOrWhiteSpace(action) && !action.Equals("������"))
            {
                var uri = new Uri($"tel:{action.Replace(" ", "").Replace("(", "").Replace(")", "")}");

                await Launcher.OpenAsync(uri);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"�� ������� ��������� ������: {ex.Message}");
        }
    }
}