using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BusinessLayer.Repository
{
    public class AccountInformationRepository : Repository<AccountInformation>
    {
        #region Admin
        public IEnumerable<AccountInformationVM> GetList(string Name)
        {
            IEnumerable<AccountInformation> list = GetAll(c => c.Name.Contains(Name));
            foreach (AccountInformation ai in list)
            {
                yield return mapper.Map<AccountInformationVM>(ai);
            }
        }

        public void AddAccountInformation(AccountInformationVM c)
        {
            if (c.Validate().Length == 0)
            {
                AccountInformation ai = mapper.Map<AccountInformation>(c);
                Add(ai);
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void UpdateAccountInformation(AccountInformationVM c)
        {
            if (c.Validate().Length == 0)
            {
                AccountInformation ai = GetById(c.Id);
                mapper.Map(c, ai);
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void DeleteAccountInformation(int id)
        {
            Remove(id);
            Save();
        }

        public void LoadComboBoxAccount(ComboBox cbb)
        {
            List<Account> listAC = _db.Accounts.ToList();
            foreach (Account ac in listAC)
            {
                cbb.Items.Add(new CBBItem
                {
                    Value = ac.Id,
                    Text = ac.UserName
                });
            }
        }
        #endregion

        #region All User
        public AccountInformationVM GetAIByAccountId(int Account_Id)
        {
            AccountInformation ai = GetFirstOrDefault(c => c.Account_Id == Account_Id);
            if (ai == null) return null;
            return mapper.Map<AccountInformationVM>(ai);
        }
        #endregion
    }
}
