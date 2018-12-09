using Acr.UserDialogs;
using Fresh1.Models;
using Fresh1.Services;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fresh1.PageModels
{
    public class ContactPageModel : FreshMvvm.FreshBasePageModel
    {
        private readonly IUserDialogs _userDialog;
        private readonly IStringWorker _stringWorker;

        public ContactPageModel(IStringWorker stringWorker, IUserDialogs userDialogs)
        {
            _stringWorker = stringWorker;
            _userDialog = userDialogs;
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Contact = initData as Contact;
        }

        private Contact contact;
        public Contact Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        private ICommand saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                return saveCommand ?? (saveCommand = new Command(async () => 
                {
                    //await CoreMethods.PopPageModel();
                    string result = _stringWorker.SumString(Contact.Name, Contact.LastName);
                    await CoreMethods.DisplayAlert("Full name", result, "Ok");
                }));
            }
        }

    }
}
