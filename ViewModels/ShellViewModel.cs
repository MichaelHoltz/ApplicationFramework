using ApplicationFramework.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationFramework.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _firstName = "Michael";
        private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;
        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Michael", LastName = "Holtz" });
            People.Add(new PersonModel { FirstName = "Charity", LastName = "Holtz" });
            People.Add(new PersonModel { FirstName = "Benjamin", LastName = "Ramirez" });
            People.Add(new PersonModel { FirstName = "Matt", LastName = "Zielinski" });
        }
        public string FirstName
        {
            get 
            { 
                return _firstName; 
            }
            set 
            { 
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
        
        public string LastName
        {
            get { return _lastName; }
            set 
            { 
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
        
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        
        }
       

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set 
            { 
                _people = value; 

            }
        }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set { 
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }
        /// <summary>
        /// Used to enable or disable the button based on convention
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool CanClearText(string firstName, string lastName)
        {
            //return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            return true;

        }
#pragma warning disable IDE0060 // Remove unused parameter
        public void ClearText(string firstName, string lastName)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            FirstName = "";
            LastName = "";
        }

        /// <summary>
        /// 1:14:00 in tutorial video
        /// </summary>
        public void LoadPageOne()
        {
            //Note ActivateItem doesn't exist.. maybe removed to make it Async
            ActivateItemAsync(new FirstChildViewModel());
        }
        /// <summary>
        /// 1:18:29
        /// </summary>
        public void LoadPageTwo()
        {
            ActivateItemAsync(new SecondChildViewModel());
        }

    }
}
