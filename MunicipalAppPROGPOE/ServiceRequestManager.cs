using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalAppPROGPOE
{
    public class ServiceRequestManager
    {
        AVLTree aVLTree = new AVLTree();
        ServiceRequestGraph ServiceRequestGraph = new ServiceRequestGraph();
        //public string filePath = "C:\\Users\\moolm\\source\\Cloned_Repos\\vcnmb-prog7312-2024-poe-Stephan2001\\municipal_service_requests.csv";
        //public string filePath2 = "C:\\Users\\moolm\\source\\Cloned_Repos\\vcnmb-prog7312-2024-poe-Stephan2001\\municipal_service_dependancies.csv";
        // correct base path C:\Users\moolm\source\Cloned_Repos\vcnmb-prog7312-2024-poe-Stephan2001\MunicipalAppPROGPOE\bin\Debug\net8.0-windows
        public string filePath;
        public string filePath2;
        public ServiceRequestManager()
        {
            filePath = GetFilePath("municipal_service_requests.csv");
            filePath2 = GetFilePath("municipal_service_dependancies.csv");
            ReadFromCSV();
            ReadFromCSV2();
        }

        public string GetFilePath(string fileName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Application's base directory
            return Path.Combine(basePath, fileName);
        }

        public ServiceRequest GetMyDependancies(string key)
        {
            return ServiceRequestGraph.getDependancyNode(key);
        }

        public Dictionary<string, int> statusStatistics()
        {
           return aVLTree.CountRequestsByStatus();
        }

        public List<ServiceRequest> defaultDisplay()
        {
            return aVLTree.GetAllServiceRequests();
        }

        public List<string> GetAllIds()
        {
            return ServiceRequestGraph.GetAllIds();
        }

        public List<ServiceRequest> searchRequest(string key)
        {
            List<ServiceRequest> list = new List<ServiceRequest>();
            var x = aVLTree.Search(key);
            if (x != null)
            {
                list.Add(x);
                return list;
            }
            else
                return list;
        }

        // for searching based on both filters
        public List<ServiceRequest> searchJoined(string key1, string key2)
        {
            var list1 = ServiceRequestGraph.getLocationNodes(key1);
            var list2 = ServiceRequestGraph.getDepartmentNodes(key2);
            return list1.Intersect(list2).ToList();
        }

        public List<ServiceRequest> searchLocations(string key)
        {
            return ServiceRequestGraph.getLocationNodes(key);
        }

        public List<ServiceRequest> searchDepartments(string key)
        {
            return ServiceRequestGraph.getDepartmentNodes(key);
        }

        public void ReadFromCSV()
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] columns = line.Split(',');

                        if (columns.Length >= 3)
                        {
                            string id = columns[0];
                            string date = columns[1];
                            string title = columns[2];
                            string location = columns[3];
                            string department = columns[4];
                            string status = columns[5];

                            ServiceRequest request = new ServiceRequest(id, date, title, location, department, status);
                            aVLTree.Insert(request);
                            ServiceRequestGraph.AddServiceRequest(request);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading CSV file: " + e.Message);
            }
        }

        public void ReadFromCSV2()
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath2))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] columns = line.Split(',');

                        if (columns.Length >= 2)
                        {
                            string source = columns[0];
                            string destination = columns[1];
                            ServiceRequestGraph.addEdges(source, destination);
                            
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error reading CSV file: " + e.Message);
            }
        }

        public List<string> GetAllDepartments()
        {
            return ServiceRequestGraph.GetAllDepartments();
        }

        public List<string> GetAllLocations()
        {
            return ServiceRequestGraph.GetAllLocations();
        }

        public List<ServiceRequest> GetLongestDependencyChain()
        {
            return ServiceRequestGraph.GetLongestDependencyChain();
        }

        public bool AreRequestsConnected(string sourceID, string destinationID)
        {
            return ServiceRequestGraph.AreRequestsConnected(sourceID, destinationID);
        }
    }
}
