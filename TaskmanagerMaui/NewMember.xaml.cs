using CommunityToolkit.Maui.Views;
namespace TaskManager;

public partial class NewTask : CommunityToolkit.Maui.Views.Popup
{
    public NewTask()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
    }

    DatePicker datePicker = new DatePicker
    {
        MinimumDate = new DateTime(2018, 1, 1),
        MaximumDate = new DateTime(2018, 12, 31),
        Date = new DateTime(2018, 6, 21)
    };
    TimePicker timePicker = new TimePicker
    {
        Time = new TimeSpan(4, 15, 26)
    };
    //var taskList = new List<string>();

    //TaskList.Add("Task1");
    //TaskList.Add("Task2");
    //TaskList.Add("Task3");
    //TaskList.Add("Task4");
    //TaskList.Add("Task5");
    //TaskList.Add("Task6");
    //TaskList.Add("Task7");

    Picker picker = new Picker
    {
        Title = "Select a task"
    };

    //Picker.ItemsSource = TaskList;

}