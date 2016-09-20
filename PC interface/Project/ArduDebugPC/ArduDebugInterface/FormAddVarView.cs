using System;
using System.Windows.Forms;

namespace ArduDebug
{
    public partial class FormAddVarView : Form
    {
        bool m_IsConfirmed = false;

        clsVariableInfo Item = null;

        

        public FormAddVarView()
        {
            InitializeComponent();
        }

        public void SetItem(clsVariableInfo ItemToSet)
        {
            if (ItemToSet != null)
            {
                Item = ItemToSet;

                lblVarName.Text = Item.VarName;
                lblSize.Text = Item.Size.ToString();

                InitRadio();
            }
        }

        private void InitRadio()
        {
            switch(Item.Size)
            {
                case 1:
                    radioByte.Enabled = true;
                    radioShort.Enabled = false;
                    radioUshort.Enabled = false;
                    radioLong.Enabled = false;
                    radioUlong.Enabled = false;
                    radioFloat.Enabled = false;
                    radioByteArray.Enabled = false;
                    radioString.Enabled = false;

                    radioByte.Checked = true;
                    break;

                case 2:
                    radioByte.Enabled = false;
                    radioShort.Enabled = true;
                    radioUshort.Enabled = true;
                    radioLong.Enabled = false;
                    radioUlong.Enabled = false;
                    radioFloat.Enabled = false;
                    radioByteArray.Enabled = true;
                    radioString.Enabled = true;

                    radioShort.Checked = true;
                    break;

                case 4:
                    radioByte.Enabled = false;
                    radioShort.Enabled = false;
                    radioUshort.Enabled = false;
                    radioLong.Enabled = true;
                    radioUlong.Enabled = true;
                    radioFloat.Enabled = true;
                    radioByteArray.Enabled = true;
                    radioString.Enabled = true;

                    radioLong.Checked = true;
                    break;

                default:
                    radioByte.Enabled = false;
                    radioShort.Enabled = false;
                    radioUshort.Enabled = false;
                    radioLong.Enabled = false;
                    radioUlong.Enabled = false;
                    radioFloat.Enabled = false;
                    radioByteArray.Enabled = true;
                    radioString.Enabled = true;

                    radioString.Checked = true;
                    break;
            }
        }

        public bool IsConfirmed
        {
            get
            {
                return m_IsConfirmed;
            }
        }

        private void GetTypeSelection()
        {
            if (radioByte.Checked)
            {
                Item.Settype(new byte());
            }
            else if (radioShort.Checked)
            {
                Item.Settype(new Int16());
            }
            else if (radioUshort.Checked)
            {
                Item.Settype(new UInt16());
            }
            else if (radioLong.Checked)
            {
                Item.Settype(new Int32());
            }
            else if (radioUlong.Checked)
            {
                Item.Settype(new UInt32());
            }
            else if (radioFloat.Checked)
            {
                Item.Settype(new float());
            }
            else if (radioByteArray.Checked)
            {
                Item.Settype(new byte[Item.Size]);
            }
            else if (radioString.Checked)
            {
                Item.Settype(new string(' ',Item.Size));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetTypeSelection();
            m_IsConfirmed = true;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_IsConfirmed = false;

            Close();
        }
    }
}
