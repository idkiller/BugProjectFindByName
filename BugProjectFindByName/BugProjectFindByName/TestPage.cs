using Xamarin.Forms;

namespace BugProjectFindByName
{
    public class TestPage : ContentPage
    {
        public TestPage()
        {
            var element = this.FindByName<Button>("Foo");

            if (element != null)
            {
                element.Text = "Success";
            }
        }
    }
}
