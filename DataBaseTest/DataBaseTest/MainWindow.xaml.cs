using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DataBaseTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentDbContext StudentDBC;
        public MainWindow()
        {
            StudentDBC = new StudentDbContext();
            InitializeComponent();
            StudentDBC.Students.OrderBy(x => x.Id).Load();
            stud2 = StudentDBC.Students.Local;
            StudentsDataGrid.ItemsSource = stud2;
            foreach(Student student in stud2)
            {
                if (student.Id > maxid)
                {
                    maxid = student.Id;
                }
                maxid = maxid + 1;
            }
        }
        ObservableCollection<Student> stud2;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                StudentDBC.SaveChanges();

            }
            catch(Exception ex)
            {
                MessageBox.Show("У вас ошибка: " + ex.Message);
            }


        }
        int maxid = 0;
        private void dobavit(object sender, RoutedEventArgs e)
        {
            stud2.Add(new Student(maxid));
            maxid = maxid + 1;
        }
    }

}
