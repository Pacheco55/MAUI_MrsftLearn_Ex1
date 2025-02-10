namespace ejercicio1
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

        public MainPage()
        {
            InitializeComponent();

            editor.Text = File.Exists(_fileName) ? File.ReadAllText(_fileName) : string.Empty;

            //saveButton.Clicked += OnSaveButtonClicked;

            //deleteButton.Clicked += OnDeleteButtonClicked;
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, editor.Text);
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor.Text = string.Empty;
        }

    }
}


       