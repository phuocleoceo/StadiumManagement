﻿using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Repository
{
    public class AccountInformationRepository : Repository<AccountInformation>
    {
        #region Admin
        public List<AccountInformationVM> GetList()
        {
            List<AccountInformation> list = GetAll();
            List<AccountInformationVM> listVM = new List<AccountInformationVM>();
            foreach(AccountInformation ai in list)
            {
                listVM.Add(mapper.Map<AccountInformationVM>(ai));
            }
            return listVM;
        }

        public void AddAccountInformation(AccountInformationVM c)
        {
            AccountInformation ai = mapper.Map<AccountInformation>(c);
            Add(ai);
            Save();
        }

        public void UpdateAccountInformation(AccountInformationVM aivm)
        {
            AccountInformation ai = GetById(aivm.Id);
            mapper.Map(aivm, ai);
            Save();
        }

        public void DeleteAccountInformation(int id)
        {
            Remove(id);
            Save();
        }

        public List<CBBItem> LoadComboBox()
        {
            List<Account> listAC = _db.Accounts.ToList();
            List<CBBItem> list = new List<CBBItem>();
            foreach (Account ac in listAC)
            {
                list.Add(new CBBItem
                {
                    Value = ac.Id,
                    Text = ac.UserName
                });
            }
            return list;
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
