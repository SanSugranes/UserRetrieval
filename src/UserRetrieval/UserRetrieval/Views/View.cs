/// ETML
/// Author      : Santiago Sugrañes
/// Date        : 10.01.2022
/// Description : Application main view, displays the data to the user

using System.Windows.Forms;
using UserRetrieval.Controllers;

namespace UserRetrieval.Views
{
    /// <summary>
    /// User Interface Class
    /// </summary>
    public partial class View : Form
    {
        /// <summary>
        /// Property
        /// </summary>
        internal Controller Ctrler { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public View()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the text to the text label
        /// </summary>
        /// <param name="userInfos"></param>
        internal void SetText(string userInfos)
        {
            this.lblUserName.Text = userInfos;
        }
    }
}
