using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PexelsDotNetSDK.Api;
using PexelsDotNetSDK.Models;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace MunicipalAppPROGPOE
{
    public partial class frmLocalEvents : Form
    {
        string hintText = "Enter name, keywords or dates (dd/mm/yyy|dd-mm-yyyy|dd MMMM yyyy)";
        Event currentEvent;
        Event currentRecomendation;
        SearchManager searchManager = new SearchManager();
        public frmLocalEvents()
        {
            InitializeComponent();
        }

        private void btnLESearchQuery_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLESearchQuery.Text) && txtLESearchQuery.Text != hintText)
            {
                panel4.Visible = true;
                Debug.WriteLine("I am not empty");
                searchManager.ManageSearch(txtLESearchQuery.Text);
                if (searchManager.eventQueue.Count > 0)
                {
                    lblMeswagebox2.Text = searchManager.eventQueue.Count + " events found";
                    lblMeswagebox2.Visible = true;
                    btnLEEventNext_Click(sender, e);
                    btnLERecomendNext_Click(sender, e);
                }
                else
                {
                    lblMeswagebox2.Text = "Records are empty";
                    lblMeswagebox2.Visible = true;
                }
            }
            else
            {
                lblMeswagebox2.Text = "Search query is empty";
                lblMeswagebox2.Visible = true;
            }
        }

        private void btnLEEventBack_Click(object sender, EventArgs e)
        {
            if (searchManager.eventStack.Count > 0)
            {
                currentEvent = searchManager.PreviousEvent(); 

                if (currentEvent != null)
                {
                    UpdateEvents();
                }
                Debug.WriteLine("");
                Debug.WriteLine("");
                foreach (var item in searchManager.eventQueue) { Debug.WriteLine("Que: " + item.Name); }
                foreach (var item in searchManager.eventStack) { Debug.WriteLine("Stack: " + item.Name); }
            }
        }

        private void btnLEEventNext_Click(object sender, EventArgs e)
        {
            currentEvent = searchManager.NextEvent();
            if (currentEvent != null)
            {
                UpdateEvents();
            }
            Debug.WriteLine("");
            Debug.WriteLine("");
            foreach (var item in searchManager.eventQueue) { Debug.WriteLine("Que: " +item.Name); }
            foreach (var item in searchManager.eventStack) { Debug.WriteLine("Stack: " + item.Name); }
        }

        private void btnLERecomendNext_Click(object sender, EventArgs e)
        {
            if (searchManager.recommendedStack.Count > 0)
            {
                currentRecomendation = searchManager.NextRecomendedEvent();
                if (currentEvent != null)
                {
                    UpdateRecomended();
                }
            }
        }

        public void UpdateEvents()
        {
            Random random = new Random();
            txtLEEventKeywords.Items.Clear();
            txtLEEventKeywords.Items.Add("Keywords:");
            List<string> keywords = new List<string>();
            foreach (var keyword in currentEvent.Tags)
            {
                keywords.Add(keyword);
                txtLEEventKeywords.Items.Add(keyword);
            }
            txtLEEventName.Text = currentEvent.Name;
            txtLEEventDate.Text = currentEvent.Date;
            int rand = random.Next(0, keywords.Count);
            Debug.WriteLine("rand num: " + rand);
            SearchImages(keywords[rand]);
        }

        // loads related image form api
        public async void SearchImages(string query)
        {
            Random random = new Random();
            AppConfig config = LoadConfiguration();
            PexelsClient pexelsClient = new PexelsClient(config.ApiKey);
            var searchResult = await pexelsClient.SearchPhotosAsync(query);
            Debug.WriteLine($"Search images: {searchResult}");
            if (searchResult?.photos != null && searchResult.photos.Any())
            {
                var photo = searchResult.photos[random.Next(0, searchResult.photos.Count-1)];
                if (photo != null)
                {
                    pictureBox1.ImageLocation = photo.source.small;
                }
            }
            else { Debug.WriteLine("No img found"); }
        }

        public void UpdateRecomended()
        {
            txtLERecomendName.Text = currentRecomendation.Name;
        }

        private void InitializeHintText()
        {
            txtLESearchQuery.Text = hintText;
            txtLESearchQuery.ForeColor = Color.Gray;

            // Handle events
            txtLESearchQuery.Enter += txtLESearchQuery_Enter;
            txtLESearchQuery.Leave += txtLESearchQuery_Leave;
        }

        private void txtLESearchQuery_Enter(object sender, EventArgs e)
        {
            if (txtLESearchQuery.Text == hintText)
            {
                txtLESearchQuery.Text = "";
                txtLESearchQuery.ForeColor = Color.Black;
            }
        }

        private void txtLESearchQuery_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLESearchQuery.Text))
            {
                txtLESearchQuery.Text = hintText;
                txtLESearchQuery.ForeColor = Color.Gray;
            }
        }

        public AppConfig LoadConfiguration()
        {
            string json = File.ReadAllText("config.json"); // Read the JSON file
            AppConfig config = JsonConvert.DeserializeObject<AppConfig>(json); // Deserialize to AppConfig
            return config;
        }

    }
}
