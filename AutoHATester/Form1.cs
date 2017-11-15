using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using White = TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TreeItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.Factory;

using System.Text.RegularExpressions;
using System.Threading;

namespace AutoHATester
{
    public partial class Form1 : Form
    {
        const string _haAppName = "HomeAutomationTester";
        White.Application _haApp;
        Window _haWin;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Status_label.Text = "";
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            _haApp = White.Application.Attach(_haAppName);

            _haWin = _haApp.GetWindow(SearchCriteria.ByAutomationId("MainWindow"), InitializeOption.NoCache);

            // Unload any plugin
            var loadButton = _haWin.Get(SearchCriteria.ByAutomationId("LoadPluginButton"));
            if (!loadButton.Enabled)
            {
                var unloadButton = _haWin.Get(SearchCriteria.ByAutomationId("UnLoadPluginButton"));
                unloadButton.Click();
            }

            // Remove all devices from grid
            Status_label.Text = "Remove all devices";
            var grid = _haWin.Get<White.UIItems.ListView>(SearchCriteria.ByAutomationId("DeviceDataGrid"));
            while(grid.Items.Count > 0)
            {
                grid.Select(0);
                grid.KeyIn(White.WindowsAPI.KeyboardInput.SpecialKeys.DELETE);
            }

            // Find and Select product
            Status_label.Text = "Select Product";
            var products_combo = _haWin.Get<White.UIItems.ListBoxItems.ComboBox>(SearchCriteria.ByAutomationId("ProductsCombo"));
            Regex regx = new Regex(Product_textBox.Text);
            White.UIItems.ListBoxItems.ListItem found_item = null;
            foreach (var item in products_combo.Items)
            {
                string text = item.Text;
                if (regx.Match(item.Text).Success)
                {
                    found_item = item;
                    break;
                }
            }
            if (products_combo == null)
                throw new Exception("Product no found");
            products_combo.Select(found_item.Text);

            // Load plugin
            Status_label.Text = "Load Plugin";
            loadButton.Click();

            // Permit join
            Status_label.Text = "Enable Permit Joining";
            var permitLabel = _haWin.Get<White.UIItems.Label>(SearchCriteria.ByAutomationId("PermiteJoiningEnabledLabel"));
            var permitJoinButton = _haWin.Get<White.UIItems.Button>(SearchCriteria.ByAutomationId("PermitJoiningButton"));
            if (!permitLabel.Visible)
            {
                permitJoinButton.Click();
            }

            // Wait for item to joing
            Status_label.Text = "Waiting for device to join";
            while (grid.Items.Count == 0)
            {
                Thread.Sleep(100);
            }

            // disable permit joining
            Status_label.Text = "Disable Permit Joining";
            permitJoinButton.Click();

        }
    }


}
