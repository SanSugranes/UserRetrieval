/// ETML
/// Author      : Santiago Sugrañes
/// Date        : 10.01.2022
/// Description : Application controller, gets the data from model and sets it to the view
using System.Windows.Forms;
using UserRetrieval.Buisness;
using UserRetrieval.Models;
using View = UserRetrieval.Views.View;

namespace UserRetrieval.Controllers
{
    /// <summary>
    /// Controller Class
    /// </summary>
    class Controller
    {
        /// <summary>
        /// Attrivutes
        /// </summary>
        private readonly View _view = new View();
        private readonly Model _model = new Model();

        /// <summary>
        /// Default constructor
        /// </summary>
        public Controller()
        {
            this._view.Ctrler = this;
            SetViewText();
        }

        internal void RunMainView()
        {
            Application.Run(this._view);
        }

        private void SetViewText()
        {
            string userInfos = this._model.GetUserInfos();
            this._view.SetText(userInfos);
            Logger.Log(Logger.LogLevel.INFO, $"{userInfos} connected successfully");
            AddToFile(userInfos);
        } 

        private void AddToFile(string userInfos)
        {
            Logger.AppendToUsers(userInfos);
        }
    }
}
