using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFDesignDemo.ViewModels.DataDisplay
{
    public class DataGridViewModel : BindableBase
    {
        private ObservableCollection<People> _Peoples = new ObservableCollection<People>();

        public ObservableCollection<People> Peoples
        {
            get { return _Peoples; }
            set { _Peoples = value; RaisePropertyChanged(); }
        }

        public DataGridViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                int id = i + 1;
                string name = "朝阳群众" + i.ToString();
                int age = new Random().Next(0, 100);
                string sex = age % new Random().Next(1, 5) == 0 ? "男" : "女";
                this.Peoples.Add(new People()
                {
                    ID = id,
                    Name = name,
                    Age = age,
                    Sex = sex
                });
            }
        }
    }

    public class People
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}
