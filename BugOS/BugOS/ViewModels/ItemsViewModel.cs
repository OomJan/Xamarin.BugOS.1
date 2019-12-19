using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using BugOS.Models;

namespace BugOS.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public Command DoStuffCommand { get; set; }

        private SomeClass m_Something;

        public ItemsViewModel()
        {
            Title = "Browse";
            DoStuffCommand = new Command(c => ExecuteDoStuffCommand());
        }

        void ExecuteDoStuffCommand()
        {
            SomeClass tSomething = new SomeClass();

            tSomething.SomeProperty = "Passed";
            tSomething.AnotherProperty = "Well done.";

            this.Something = tSomething;
        }

        public SomeClass Something
        {
            get { return m_Something; }
            set
            {
                this.m_Something= value;

                //Boom
                OnPropertyChanged();
            }
        }
    }
}