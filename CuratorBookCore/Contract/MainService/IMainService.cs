using CuratorBookCore.Data.Tables;
using System.Collections.Generic;

namespace CuratorBookCore.Contract.MainService
{
    public interface IMainService
    {
        IList<Pages> GetListPages(Roles role);
        Roles GetDefaultRole();

        string GetPictureForCommonPage(int pageId);

        Users Authenticate(string email, string password);
        string AddNewUser(Users user);

        Forms GetFormModel(int pageId);

        IList<AnswerRows> GetAnswers(int formId, int groupId);
        void SaveAnswers(int formId, int groupId, IList<AnswerRows> model);

        IList<AnswerRows> GetTemplatesForUser(int formId, int userId);
        void SaveTemplatesForUser(int formId, int userId, IList<AnswerRows> templates);

        void PushMessage(Messages msg);
        IList<Messages> GetMessages(int userId);

        IList<AnswerRows> GetSchedule(int groupId);
        void SaveSchedule(int groupId, IList<AnswerRows> templates);

        Interviews GetInterview(int userId);
        void SaveInterview(int userId, Interviews interview);

        IList<RolesRights> GetRightsForRoles();
        void SaveRightForRoles(RolesRights right);

        IList<UsersRights> GetRightsForUsers();
        void SaveRightForUsers(UsersRights right);
    }
}
