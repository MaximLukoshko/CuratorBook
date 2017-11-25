using System.Collections.Generic;
using CuratorBookCore.Data.Tables;
using CuratorBook.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CuratorBookCore.Contract.MainService
{
    public class MainService : IMainService
    {
        protected CuratorBookDbContext Context = new CuratorBookDbContext();

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
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
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
