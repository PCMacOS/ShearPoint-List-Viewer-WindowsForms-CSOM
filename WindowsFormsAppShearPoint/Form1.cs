using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  SP = Microsoft.SharePoint.Client;
using System.Net;
using System.Security;

namespace WindowsFormsAppShearPoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUrl.Text = @"http://student7.trainhub.local";
            txtPass.Text = @"P@ssw0rd1";
            txtUsername.Text = @"ths_admin";
        }

        public static SP.ClientContext clientContext;
        public static SP.ListCollection siteList;
        private void LoadLists(object sender, EventArgs e)
        {
            try
            {
                SP.Web sPweb = clientContext.Web;

                siteList = sPweb.Lists;
                //clientContext.Load((sPweb));

                logsTextBox.AppendText("Lists Loading.." + Environment.NewLine);
                clientContext.Load((siteList));
                clientContext.ExecuteQuery();

                logsTextBox.AppendText("Lists Loaded" + Environment.NewLine);

                List<DataGridShearPointList> listSource = new List<DataGridShearPointList>();

                foreach (SP.List list in siteList)
                {
                    listSource.Add(new DataGridShearPointList()
                    {
                        Id = list.Id.ToString(),
                        Selected = false,
                        Name = list.Title,
                        Type = list.BaseType.ToString()
                    });
                }

                dataGridGetList.DataSource = listSource;

                logsTextBox.AppendText("Lists Viewed" + Environment.NewLine);
            }
            catch (Exception exception)
            {
                logsTextBox.AppendText("You don't connect connect to ShearPoint" + Environment.NewLine);
            }
        }

        private void ButtonLoadRecords_Click(object sender, EventArgs e)
        {
            List<DataGridShearPointList> recordSource = new List<DataGridShearPointList>();
            foreach (DataGridViewRow row in dataGridGetList.Rows)
            {
                DataGridShearPointList selectedObjectRow = (DataGridShearPointList)row.DataBoundItem;

                if (selectedObjectRow.Selected == true)
                {
                    SP.List selectedList = siteList.FirstOrDefault(x => x.Id.ToString() == selectedObjectRow.Id);
                    //selectedList = sPweb.Lists.GetByTitle(selectedObjectRow.Name);
                    if (selectedList != null)
                    {
                        SP.CamlQuery camlQuery = new SP.CamlQuery();
                        camlQuery.ViewXml = "<View><Query><OrderBy><FieldRef Name='ID'/></OrderBy></Query><RowLimit>10</RowLimit></View>";

                        SP.ListItemCollection collListItems = selectedList.GetItems(camlQuery);

                        logsTextBox.AppendText("Selected Lists Item Loading.." + Environment.NewLine);
                        clientContext.Load(collListItems);
                        clientContext.ExecuteQuery();
                        logsTextBox.AppendText("Selected Lists Item Load" + Environment.NewLine);

                        foreach (SP.ListItem listItem in collListItems)
                        {
                                recordSource.Add(new DataGridShearPointList()
                                {
                                    Name = listItem["Title"]?.ToString(),
                                    Id = listItem.Id.ToString()
                                });
                        }
                    }

                }
            }
            dataGridViewList.DataSource = recordSource;
            logsTextBox.AppendText("Selected Lists Item Viewed" + Environment.NewLine);
        }

        private void ButtonLoadPermisions_Click(object sender, EventArgs e)
        {
            //if (bindingList.Count == 0)
            //{
            //    log("Lists are empty", true);
            //    return;
            //}
            //List<ListPermission> listPermissions = new List<ListPermission>();
            //SP.Web myWeb = clientContext.Web;
            
            //foreach (ListObject list in bindingList)
            //{
            //    if (!list.Selected)
            //        continue;
            //    SP.List _list = siteLists.Where(o => list.Id == o.Id.ToString()).FirstOrDefault();
            //    SP.RoleAssignmentCollection roles = _list.RoleAssignments;
            //    clientContext.Load(roles);
            //    clientContext.ExecuteQuery();
            //    foreach (SP.RoleAssignment role in roles)
            //    {
            //        clientContext.Load(role.Member);
            //        clientContext.Load(role.RoleDefinitionBindings);
            //        clientContext.ExecuteQuery();
            //        ListPermission listPermission = new ListPermission();
            //        try
            //        {
            //            foreach (var roledef in role.RoleDefinitionBindings)
            //            {
            //                listPermission.ListName = _list.Title;
            //                listPermission.Name = role.Member.Title;
            //                listPermission.Permission = roledef.Name;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            log("Error loading permissions", true);
            //        }
            //        listPermissions.Add(listPermission);
            //    }
            //}
            //data_items.DataSource = listPermissions;
        }

        private void ConectSiteButton_Click(object sender, EventArgs e)
        {
            string siteUrl = txtUrl.Text;
            string sitePass = txtPass.Text;
            string siteUsername = txtUsername.Text;


            if (string.IsNullOrWhiteSpace(siteUrl)) logsTextBox.AppendText("Url is null" + Environment.NewLine);
            if (string.IsNullOrWhiteSpace(sitePass)) logsTextBox.AppendText("Pass is nul" + Environment.NewLine);
            if (string.IsNullOrWhiteSpace(siteUsername)) logsTextBox.AppendText("Username is null" + Environment.NewLine);

            //Make a string to secure string
            // SecureString securePassword =new SecureString();
            // foreach (char c in sitePass) securePassword.AppendChar(c);
            ///////////////
            /// 
            clientContext = new SP.ClientContext(siteUrl);
            clientContext.Credentials = new NetworkCredential(siteUsername, sitePass, "trainhub");
            logsTextBox.AppendText("Connect Sasses" + Environment.NewLine);
        }
    }
}
