using System.Collections.Generic;
using CuratorBookCore.Data.Tables;
using CuratorBook.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace CuratorBookCore.Contract.MainService
{
    public class MainService : IMainService
    {
        protected CuratorBookDbContext Context = new CuratorBookDbContext();

        public string AddNewUser(Users user)
        {
            var error = string.Empty;
            if (Context.Users.All(n => !n.Email.Equals(user.Email, StringComparison.OrdinalIgnoreCase))) {
                Context.Users.Add(user);
            }
            else {
                error = "Данный Email занят";
            }
            return error;
        }

        public Users Authenticate(string email, string password)
        {
            return Context.Users.SingleOrDefault(n => n.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && n.Password.Equals(password));
        }

        public IList<AnswerRows> GetAnswers(int formId, int groupId)
        {
            throw new System.NotImplementedException();
        }

        public Roles GetDefaultRole()
        {
            return Context.Roles.Include(n => n.RolesRights).Where(n => n.Id == (int)RolesEn.Guest).SingleOrDefault();
        }

        public Forms GetFormModel(int pageId)
        {
            throw new System.NotImplementedException();
        }

        public Interviews GetInterview(int userId)
        {
            return Context.Interviews.SingleOrDefault(n => n.UserId == userId);
        }

        public IList<Pages> GetListPages(Roles role)
        {
            return Context.Pages.Where(n => role.RolesRights.Any(rr => n.Rights.Id == rr.Id)).ToList();
        }

        public IList<Messages> GetMessages(int userId)
        {
            throw new System.NotImplementedException();
        }

        public string GetPictureForCommonPage(int pageId)
        {
            return $"CommonInfo_{pageId}.jpg";
        }

        public IList<RolesRights> GetRightsForRoles()
        {
            throw new System.NotImplementedException();
        }

        public IList<UsersRights> GetRightsForUsers()
        {
            throw new System.NotImplementedException();
        }

        public IList<AnswerRows> GetSchedule(int groupId)
        {
            throw new System.NotImplementedException();
        }

        public IList<AnswerRows> GetTemplatesForUser(int formId, int userId)
        {
            throw new System.NotImplementedException();
        }

        public void PushMessage(Messages msg)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAnswers(int formId, int groupId, IList<AnswerRows> model)
        {
            throw new System.NotImplementedException();
        }

        public void SaveInterview(int userId, Interviews interview)
        {
            throw new System.NotImplementedException();
        }

        public void SaveRightForRoles(RolesRights right)
        {
            throw new System.NotImplementedException();
        }

        public void SaveRightForUsers(UsersRights right)
        {
            throw new System.NotImplementedException();
        }

        public void SaveSchedule(int groupId, IList<AnswerRows> templates)
        {
            throw new System.NotImplementedException();
        }

        public void SaveTemplatesForUser(int formId, int userId, IList<AnswerRows> templates)
        {
            throw new System.NotImplementedException();
        }
    }
}
