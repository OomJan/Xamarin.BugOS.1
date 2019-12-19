using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BugOS.Annotations;

namespace BugOS.ViewModels
{
    public class SomeClass : INotifyPropertyChanged
    {
        private string m_SomeProperty;
        private string m_AnotherProperty;
        private SomeStruct m_ButThisProperty;

        public string SomeProperty
        {
            get { return m_SomeProperty; }
            set
            {
                this.m_SomeProperty = value;

                OnPropertyChanged();
            }
        }

        public string AnotherProperty
        {
            get { return m_AnotherProperty; }
            set
            {
                this.m_AnotherProperty = value;

                OnPropertyChanged();
            }
        }

        public SomeStruct ButThisProperty
        {
            get { return m_ButThisProperty; }
            set
            {
                this.m_ButThisProperty = value;

                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] String PropertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
