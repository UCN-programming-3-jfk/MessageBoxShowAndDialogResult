using System;
using System.Windows.Forms;

namespace MessageBoxShowAndDialogResult;
public partial class Form1 : Form
{
    #region Constructor and event handling code
    public Form1() { InitializeComponent(); }

    private void btnInfo_Click(object sender, EventArgs e) { ShowMessage(); }
    private void btnError_Click(object sender, EventArgs e) { ShowError(); }
    private void btnChoice_Click(object sender, EventArgs e) { GiveChoice(); } 
    #endregion

    private void ShowMessage()
    {
        DialogResult result = MessageBox.Show("Your file was saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        lblResult.Text = "DialogResult: " + result.ToString();
    }

    private void ShowError()
    {
        DialogResult result = MessageBox.Show("Unable to contact server. Retrying in 10 seconds.", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        lblResult.Text = "DialogResult: " + result.ToString();
    }

    private void GiveChoice()
    {
        DialogResult result = MessageBox.Show("You are about to overwrite an existing file! Continue?", "File exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        lblResult.Text = "DialogResult: " + result.ToString();
    }
}