/// ETML
/// Author      : Santiago Sugrañes
/// Date        : 10.01.2022
/// Description : Application model, retrieves all the data for the app

using System.DirectoryServices.AccountManagement;

namespace UserRetrieval.Models
{
    class Model
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Model()
        {

        }

        internal string GetUserInfos()
        {
            return UserPrincipal.Current.DisplayName;
        }
    }
}
