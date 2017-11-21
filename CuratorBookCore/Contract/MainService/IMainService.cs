using CuratorBookCore.Contract.DataModels;
using CuratorBookCore.Contract.DataModels.Answers;
using CuratorBookCore.Contract.DataModels.Rights;
using System.Collections.Generic;

namespace CuratorBookCore.Contract.MainService
{
    public interface IMainService
    {
        string GetPictureForCommonPage(string pageId);

        FormsModel GetFormModel(int pageId);

        AnswersModel GetAnswers(int formId, int groupId);
        void SaveAnswers(int formId, int groupId, AnswersModel model);

        AnswersModel GetTemplatesForUser(int formId, int userId);
        void SaveTemplatesForUser(int formId, int userId, AnswersModel templates);

        void PushMessage(MessageModel msg);
        IList<MessageModel> GetMessages(int userId);

        AnswersModel GetSchedule(int groupId);
        void SaveSchedule(int groupId, AnswersModel templates);

        InterviewModel GetInterview(int userId);
        void SaveInterview(int userId, InterviewModel interview);

        IList<RightForRoles> GetRightsForRoles();
        void SaveRightForRoles(RightForRoles right);

        IList<RightForUsers> GetRightsForUsers();
        void SaveRightForUsers(RightForUsers right);
    }
}
