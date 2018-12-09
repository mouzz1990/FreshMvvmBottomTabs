using Acr.UserDialogs;
using Fresh1.Models;
using Fresh1.Services;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fresh1.PageModels
{
    public class ContactListPageModel : FreshBasePageModel
    {
        private readonly IDataService _dataService;
        private readonly IUserDialogs _userDialogs;

        public ContactListPageModel(IDataService dataService, IUserDialogs userDialogs)
        {
            _dataService = dataService;
            _userDialogs = userDialogs;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);

            try
            {
                _userDialogs.ShowLoading("Loading contacts...", MaskType.Gradient);
                Contacts = await _dataService.GetContacts();
            }
            catch
            {

            }
            finally
            {
                _userDialogs.HideLoading();
            }
        }

        private List<Contact> contacts;
        public List<Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value; RaisePropertyChanged(); }
        }

        private Contact selectedContact;
        public Contact SelectedContact
        {
            get { return selectedContact; }
            set
            {
                selectedContact = value;
                RaisePropertyChanged();

                if (value == null) return;
                CoreMethods.PushPageModel<ContactPageModel>(value);
            }
        }

    }
}
