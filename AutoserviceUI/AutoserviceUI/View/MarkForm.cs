using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoserviceUI.View
{
    public interface IMarkInterface
    {
        string MarkID { get; set; }
        string MarkName { get; set; }
        string Country { get; set; }
        event EventHandler butInsertMarkClick;
        event EventHandler butCancelMarkClick;
        event EventHandler butDeleteMarkClick;
    }
    public partial class MarkForm : Form, IMarkInterface
    {
        public MarkForm()
        {
            InitializeComponent();
            butCancelMark.Click += butCancelMark_Click;
            butDeleteMark.Click += butDeleteMark_Click;
            butInsertMark.Click += butInsertMark_Click;
        }
        #region Проброс событий
        void butInsertMark_Click(object sender, EventArgs e)
        {
            if (butInsertMarkClick != null) butInsertMarkClick(this, EventArgs.Empty);
        }

        void butDeleteMark_Click(object sender, EventArgs e)
        {
            if (butDeleteMarkClick != null) butDeleteMarkClick(this, EventArgs.Empty);
        }

        void butCancelMark_Click(object sender, EventArgs e)
        {
            if (butCancelMarkClick != null) butCancelMarkClick(this, EventArgs.Empty);
        }
        public event EventHandler butInsertMarkClick;
        public event EventHandler butCancelMarkClick;
        public event EventHandler butDeleteMarkClick;
        #endregion
        #region Свойства Edit
        public string MarkID
        {
            get
            {
                return textMarkID.Text;
            }
            set
            {
                textMarkID.Text = value;
            }
        }

        public string MarkName
        {
            get
            {
                return textMarkName.Text;
            }
            set
            {
                textMarkName.Text = value;
            }
        }

        public string Country
        {
            get
            {
                return textMarkCountry.Text;
            }
            set
            {
                textMarkCountry.Text = value;
            }
        }
        #endregion

    }
}
