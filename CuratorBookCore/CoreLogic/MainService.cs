using System.Collections.Generic;
using CuratorBookCore.Contract.DataModels;
using CuratorBookCore.Contract.DataModels.Answers;
using CuratorBookCore.Contract.DataModels.Rights;

namespace CuratorBookCore.Contract.MainService
{
    public class MainService : IMainService
    {
        public AnswersModel GetAnswers(int formId, int groupId)
        {
            throw new System.NotImplementedException();
        }

        public FormsModel GetFormModel(int pageId)
        {
            throw new System.NotImplementedException();
        }

        public InterviewModel GetInterview(int userId)
        {
            throw new System.NotImplementedException();
        }

        public IList<MessageModel> GetMessages(int userId)
        {
            throw new System.NotImplementedException();
        }

        public string GetPictureForCommonPage(string pageId)
        {
            throw new System.NotImplementedException();
        }

        public IList<RightForRoles> GetRightsForRoles()
        {
            throw new System.NotImplementedException();
        }

        public IList<RightForUsers> GetRightsForUsers()
        {
            throw new System.NotImplementedException();
        }

        public AnswersModel GetSchedule(int groupId)
        {
            throw new System.NotImplementedException();
        }

        public AnswersModel GetTemplatesForUser(int formId, int userId)
        {
            throw new System.NotImplementedException();
        }

        public void PushMessage(MessageModel msg)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAnswers(int formId, int groupId, AnswersModel model)
        {
            throw new System.NotImplementedException();
        }

        public void SaveInterview(int userId, InterviewModel interview)
        {
            throw new System.NotImplementedException();
        }

        public void SaveRightForRoles(RightForRoles right)
        {
            throw new System.NotImplementedException();
        }

        public void SaveRightForUsers(RightForUsers right)
        {
            throw new System.NotImplementedException();
        }

        public void SaveSchedule(int groupId, AnswersModel templates)
        {
            throw new System.NotImplementedException();
        }

        public void SaveTemplatesForUser(int formId, int userId, AnswersModel templates)
        {
            throw new System.NotImplementedException();
        }
    }
}
