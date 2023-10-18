namespace labex_04_mobApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MoveBlackCircle(LayoutOptions horizontalOptions, LayoutOptions verticalOptions)
        {
            blackCircle.HorizontalOptions = horizontalOptions;
            blackCircle.VerticalOptions = verticalOptions;
        }

        private void OnVerticalStart(object sender, EventArgs e)
        {
            MoveBlackCircle(LayoutOptions.Start, blackCircle.VerticalOptions);
        }

        private void OnVerticalCenter(object sender, EventArgs e)
        {
            MoveBlackCircle(LayoutOptions.Start, LayoutOptions.Center);
        }

        private void OnVerticalEnd(object sender, EventArgs e)
        {
            MoveBlackCircle(LayoutOptions.Start, LayoutOptions.End);
        }

        private void OnHorizontalStart(object sender, EventArgs e)
        {
            MoveBlackCircle(LayoutOptions.Start, LayoutOptions.Center);
        }

        private void OnHorizontalCenter(object sender, EventArgs e)
        {
            MoveBlackCircle(LayoutOptions.Center, LayoutOptions.Center);
        }

        private void OnHorizontalEnd(object sender, EventArgs e)
        {
            MoveBlackCircle(LayoutOptions.End, LayoutOptions.Center);
        }
    }
}
