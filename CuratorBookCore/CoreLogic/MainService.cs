using System.Collections.Generic;
using CuratorBookCore.Data.Tables;

namespace CuratorBookCore.Contract.MainService
{
    public class MainService : IMainService
    {
        public IList<AnswerRows> GetAnswers(int formId, int groupId)
        {
            throw new System.NotImplementedException();
        }

        public Forms GetFormModel(int pageId)
        {
            throw new System.NotImplementedException();
        }

        public Interviews GetInterview(int userId)
        {
            throw new System.NotImplementedException();
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
