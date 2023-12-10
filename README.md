

----

### **Step 1: Opening Visual Studio and Creating a Project**

1. **Launching Visual Studio**: Press `Windows` key, type "Visual Studio", and press `Enter`.

2. **Creating a New .NET MAUI Project**: 
   - In Visual Studio, press `Ctrl + Shift + N` to open the "New Project" dialog.
   - Navigate to the "MAUI App" template using arrow keys and press `Enter`.

### **Step 2: Defining the `Person` Class**

3. **Adding a Class File**: 
   - In the Solution Explorer, use arrow keys to find your project.
       - That's the second file from the top
   - Press `Shift + F10`, then `A`, and `C` to add a new class.
   - Type `Person.cs` and press `Enter`.

4. **Implementing the `Person` Class**:
   - In `Person.cs`, use standard text editing shortcuts to enter the following code:

     ```csharp
     public class Person
     {
         private string firstName;
         private string lastName;

         // Constructor
         public Person(string firstName, string lastName)
         {
             this.firstName = firstName;
             this.lastName = lastName;
         }

         // Properties
         public string FirstName
         {
             get { return firstName; }
             set { firstName = value; }
         }

         public string LastName
         {
             get { return lastName; }
             set { lastName = value; }
         }

         // Method to get full name
         public string GetFullName()
         {
             return $"{FirstName} {LastName}";
         }
     }
     ```

### **Step 3: Creating a `MainPage` Instance**

5. **Editing MainPage.xaml.cs**:
   - Find and open `MainPage.xaml.cs` in the Solution Explorer.
   - Add the following code:

     ```csharp
     using YourNamespace; // Replace with the actual namespace of the Person class

     public partial class MainPage : ContentPage
     {
         private Person person;

         public MainPage()
         {
             InitializeComponent();

             person = new Person("John", "Doe"); // Creating a new instance of Person

             firstNameEntry.Text = person.FirstName;
             lastNameEntry.Text = person.LastName;
             fullNameEntry.Text = person.GetFullName();
         }
     }
     ```

### **Step 4: Defining the UI for the Main Page**

6. **Modifying MainPage.xaml**:
   - Open `MainPage.xaml` from the Solution Explorer.
   - Insert the following XML code to define the UI:

     ```xml
        <Entry x:Name="firstNameEntry" Placeholder="First Name" />
        <Entry x:Name="lastNameEntry" Placeholder="Last Name" />
        <Entry x:Name="fullNameEntry" Placeholder="Full Name" />
     ```

### **Step 5: Building and Running the Application**

7. **Building the Application**: 
   - Press `Ctrl + Shift + B` to build your solution.

8. **Running the Application**:
   - Start the application by pressing `F5`.


### **Step 6: Working with a List of `Person` and Displaying Information**

9. **Creating a List of `Person` Objects**:
   - In the `MainPage.xaml.cs`, we will create a list to store multiple `Person` objects. Add this code below the existing class members:

     ```csharp
     private List<Person> peopleList;
     ```

   - In the `MainPage` constructor, initialize this list and add some `Person` objects to it:

     ```csharp
     public MainPage()
     {
         InitializeComponent();

         // Existing Person instance code
         ...

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
     ```

10. **Creating a Method to Display Information**:
    - Now, let's create a method to loop through the list and display each person's information. Add this method to the `MainPage` class:

      ```csharp
      private void DisplayPeopleInfo()
      {
          // Use a StringBuilder for efficient string manipulation
          var stringBuilder = new System.Text.StringBuilder();

          foreach (var person in peopleList)
          {
              stringBuilder.AppendLine($"Name: {person.GetFullName()}");
          }

          // Assuming you have an Editor named 'infoEditor' in your XAML
          infoEditor.Text = stringBuilder.ToString();
      }
      ```

11. **Updating the XAML UI**:
    - In the `MainPage.xaml`, add an `Editor` control where the information will be displayed:

      ```xml
      <Editor x:Name="infoEditor" HeightRequest="100" IsReadOnly="True" />
      ```

### **Step 7: Build and Run to See the Results**

12. **Build and Run the Application Again**:
    - Press `Ctrl + Shift + B` to build your solution.
    - Press `F5` to run the application.
    - You should now see a list of names displayed in the editor on your application's main page.


---

Full Code

```xml
   <Entry x:Name="firstNameEntry" Placeholder="First Name" />
    <Entry x:Name="lastNameEntry" Placeholder="Last Name" />
    <Entry x:Name="fullNameEntry" Placeholder="Full Name" />
    <Editor x:Name="infoEditor" HeightRequest="100" IsReadOnly="True" />
   
```

MainPage.xaml.cs
```csharp
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
```

Person.cs

```csharp
public class Person
{
    private string firstName;
    private string lastName;

    // Constructor
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // Properties
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    // Method to get full name
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

```