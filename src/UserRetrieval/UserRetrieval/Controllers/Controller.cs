/// ETML
/// Author      : Santiago Sugrañes
/// Date        : 10.01.2022
/// Description : Application controller, gets the data from model and sets it to the view
using System.Windows.Forms;
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
            this._view.SetText(this._model.GetUserInfos());
        } 
    }
}
