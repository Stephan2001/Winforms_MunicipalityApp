using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalAppPROGPOE
{
    public class AVLTree
    {
        private AVLNode root;

        public AVLTree()
        {
            root = null;
        }

        // Get the height of a node
        private int Height(AVLNode node)
        {
            return node == null ? 0 : node.Height;
        }

        // Calculate the balance factor of a node
        private int GetBalance(AVLNode node)
        {
            return node == null ? 0 : Height(node.Left) - Height(node.Right);
        }

        // Right rotate
        private AVLNode RightRotate(AVLNode y)
        {
            AVLNode x = y.Left;
            AVLNode T2 = x.Right;

            // Perform rotation
            x.Right = y;
            y.Left = T2;

            // Update heights
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

            // Return new root
            return x;
        }

        // Left rotate
        private AVLNode LeftRotate(AVLNode x)
        {
            AVLNode y = x.Right;
            AVLNode T2 = y.Left;

            // Perform rotation
            y.Left = x;
            x.Right = T2;

            // Update heights
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

            // Return new root
            return y;
        }

        // Insert a new ServiceRequest
        public void Insert(ServiceRequest request)
        {
            root = InsertRecursive(root, request);
        }

        private AVLNode InsertRecursive(AVLNode node, ServiceRequest request)
        {
            if (node == null)
            {
                return new AVLNode(request);
            }

            // Compare ServiceRequestIDs
            if (string.Compare(request.ServiceRequestID, node.Data.ServiceRequestID) < 0)
            {
                node.Left = InsertRecursive(node.Left, request);
            }
            else if (string.Compare(request.ServiceRequestID, node.Data.ServiceRequestID) > 0)
            {
                node.Right = InsertRecursive(node.Right, request);
            }
            else
            {
                // Duplicate IDs are not allowed
                throw new InvalidOperationException("Duplicate ServiceRequestID is not allowed.");
            }

            // Update the height of the current node
            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;

            // Get the balance factor
            int balance = GetBalance(node);

            // Balance the tree
            // Left Left Case
            if (balance > 1 && string.Compare(request.ServiceRequestID, node.Left.Data.ServiceRequestID) < 0)
            {
                return RightRotate(node);
            }

            // Right Right Case
            if (balance < -1 && string.Compare(request.ServiceRequestID, node.Right.Data.ServiceRequestID) > 0)
            {
                return LeftRotate(node);
            }

            // Left Right Case
            if (balance > 1 && string.Compare(request.ServiceRequestID, node.Left.Data.ServiceRequestID) > 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && string.Compare(request.ServiceRequestID, node.Right.Data.ServiceRequestID) < 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        public ServiceRequest Search(string id)
        {
            return SearchRecursive(root, id);
        }

        // search for specific record
        private ServiceRequest SearchRecursive(AVLNode node, string id)
        {
            if (node == null)
                return null;

            int comparison = string.Compare(id, node.Data.ServiceRequestID);
            if (comparison == 0)
                return node.Data;
            else if (comparison < 0)
                return SearchRecursive(node.Left, id);
            else
                return SearchRecursive(node.Right, id);
        }

        // returns number of instances for each status
        public Dictionary<string, int> CountRequestsByStatus()
        {
            var statusCounts = new Dictionary<string, int>();
            CountRequestsByStatusRecursive(root, statusCounts);
            return statusCounts;
        }

        private void CountRequestsByStatusRecursive(AVLNode node, Dictionary<string, int> statusCounts)
        {
            if (node == null) return;

            // Increment the status count
            if (!statusCounts.ContainsKey(node.Data.Status))
            {
                statusCounts[node.Data.Status] = 0;
            }
            statusCounts[node.Data.Status]++;

            CountRequestsByStatusRecursive(node.Left, statusCounts);
            CountRequestsByStatusRecursive(node.Right, statusCounts);
        }

        public List<ServiceRequest> GetAllServiceRequests()
        {
            var result = new List<ServiceRequest>();
            GetAllServiceRequestsRecursive(root, result);
            return result;
        }

        // in order tree traversal
        private void GetAllServiceRequestsRecursive(AVLNode node, List<ServiceRequest> result)
        {
            if (node == null) return;

            // Traverse left subtree
            GetAllServiceRequestsRecursive(node.Left, result);

            // Add current node's service request to the result list
            result.Add(node.Data);

            // Traverse right subtree
            GetAllServiceRequestsRecursive(node.Right, result);
        }
    }
}
