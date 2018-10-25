using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

using Xamarin.Forms;

using FormsNonTrivialDemo.Models;

namespace FormsNonTrivialDemo.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Employee>();
            LoadItemsCommand = new Command(() => ExecuteLoadItemsCommand());
        }

        void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = Employee.SampleData;
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}