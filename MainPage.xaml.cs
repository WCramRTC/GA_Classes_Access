namespace GA_Classes_Access
{
    public partial class MainPage : ContentPage
    {


        private Person person;
        private List<Person> peopleList;

        public MainPage()
        {
            InitializeComponent();

            // Creating a new instance of Person
            person = new Person("John", "Doe");

            firstNameEntry.Text = person.FirstName;
            lastNameEntry.Text = person.LastName;
            fullNameEntry.Text = person.GetFullName();

            // Initialize the list and add Person objects
            peopleList = new List<Person>
        {
            new Person("John", "Doe"),
            new Person("Jane", "Doe"),
            new Person("Steve", "Smith")
        };

            // Call the method to display information
            DisplayPeopleInfo();
        }

        private void DisplayPeopleInfo()
        {
            var stringBuilder = new StringBuilder();

            foreach (var person in peopleList)
            {
                stringBuilder.AppendLine($"Name: {person.GetFullName()}");
            }

            // Assuming you have an Editor named 'infoEditor' in your XAML
            infoEditor.Text = stringBuilder.ToString();
        }

    } // end class


} // end namespace
