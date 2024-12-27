using MunicipalAppPROGPOE;
using System.Diagnostics;

public class ServiceRequestGraph
{
    private Dictionary<string, List<ServiceRequest>> locationGraph = new();
    private Dictionary<string, List<ServiceRequest>> departmentGraph = new();
    private Dictionary<string, ServiceRequest> dependancyGraph = new();

    // Add a service request as a node in graphs
    public void AddServiceRequest(ServiceRequest request)
    {
        // Location-based graph
        if (!locationGraph.ContainsKey(request.Location))
        {
            locationGraph[request.Location] = new List<ServiceRequest>();
        }
        locationGraph[request.Location].Add(request);

        // Department-based graph
        if (!departmentGraph.ContainsKey(request.ResponsibleDepartment))
        {
            departmentGraph[request.ResponsibleDepartment] = new List<ServiceRequest>();
        }
        departmentGraph[request.ResponsibleDepartment].Add(request);

        // default graph
        if (!dependancyGraph.ContainsKey(request.ServiceRequestID))
        {
            dependancyGraph[request.ServiceRequestID] = request;
        }
    }

    // Method to print the location-based graph (for testing)
    public void PrintLocationGraph()
    {
        foreach (var locationGroup in locationGraph)
        {
            Debug.WriteLine($"Location: {locationGroup.Key}");
            foreach (var request in locationGroup.Value)
            {
                Debug.WriteLine($"  - {request.ServiceTitle}");
            }
        }
    }

    // Method to print the department-based graph (for testing)
    public void PrintDepartmentGraph()
    {
        foreach (var departmentGroup in departmentGraph)
        {
            Debug.WriteLine($"Department: {departmentGroup.Key}");
            foreach (var request in departmentGroup.Value)
            {
                Debug.WriteLine($"  - {request.ServiceTitle}");
            }
        }
    }

    public void PrintAllNodesWithDependencies()
    {
        foreach (var node in dependancyGraph)
        {
            // Print the node's key (ServiceRequestID)
            Debug.WriteLine($"Node: {node.Key} ({node.Value.ServiceTitle})");

            // Print its dependencies
            if (node.Value.Dependencies.Count > 0)
            {
                Debug.WriteLine("  Dependencies:");
                foreach (var dependency in node.Value.Dependencies)
                {
                    Debug.WriteLine($"    - {dependency.ServiceRequestID} ({dependency.ServiceTitle})");
                }
            }
            else
            {
                Debug.WriteLine("  No Dependencies.");
            }
        }
    }

    public ServiceRequest getDependancyNode(string key)
    {
        return dependancyGraph[key];
    }

    public List<ServiceRequest> getLocationNodes(string key)
    {
        if (locationGraph.ContainsKey(key))
        {
            return locationGraph[key];
        }
        return new List<ServiceRequest>();
    }

    public List<ServiceRequest> getDepartmentNodes(string key)
    {
        if (departmentGraph.ContainsKey(key))
        {
            return departmentGraph[key];
        }
        return new List<ServiceRequest>();
    }

    public void addEdges(string source, string destination)
    {
        ServiceRequest s = getDependancyNode(source);
        ServiceRequest d = getDependancyNode(destination);
        Debug.WriteLine($"\n  - obj {d.ServiceRequestID} was added to {s.ServiceRequestID}\n");
        s.Dependencies.Add(d);
    }

    public List<string> GetAllDepartments()
    {
        return departmentGraph.Keys.ToList();
    }

    public List<string> GetAllIds()
    {
        return dependancyGraph.Keys.ToList();
    }

    public List<string> GetAllLocations()
    {
        return locationGraph.Keys.ToList();
    }

    public List<ServiceRequest> GetLongestDependencyChain()
    {
        var memo = new Dictionary<string, (int length, List<ServiceRequest> chain)>();
        List<ServiceRequest> longestChain = new();
        int maxLength = 0;

        foreach (var serviceRequestID in dependancyGraph.Keys)
        {
            var (length, chain) = DFSWithChain(serviceRequestID, memo);
            if (length > maxLength)
            {
                maxLength = length;
                longestChain = chain;
            }
        }

        return longestChain;
    }

    // Helper method for DFS traversal to construct the chain
    private (int length, List<ServiceRequest> chain) DFSWithChain(
        string serviceRequestID,
        Dictionary<string, (int length, List<ServiceRequest> chain)> memo)
    {
        if (memo.ContainsKey(serviceRequestID))
        {
            return memo[serviceRequestID];
        }

        var currentNode = dependancyGraph[serviceRequestID];
        int maxDepth = 0;
        List<ServiceRequest> bestChain = new();

        foreach (var dependency in currentNode.Dependencies)
        {
            var (depth, chain) = DFSWithChain(dependency.ServiceRequestID, memo);
            if (depth > maxDepth)
            {
                maxDepth = depth;
                bestChain = chain;
            }
        }

        // Include the current node in the chain
        List<ServiceRequest> currentChain = new List<ServiceRequest> { currentNode };
        currentChain.AddRange(bestChain);

        // Memoize the result
        memo[serviceRequestID] = (maxDepth + 1, currentChain);
        return memo[serviceRequestID];
    }

    public bool AreRequestsConnected(string sourceID, string destinationID)
    {
        // Get the source and destination nodes
        if (!dependancyGraph.ContainsKey(sourceID) || !dependancyGraph.ContainsKey(destinationID))
        {
            return false; // One or both service requests don't exist
        }

        var source = dependancyGraph[sourceID];
        var destination = dependancyGraph[destinationID];

        // HashSet to track visited nodes
        HashSet<string> visited = new HashSet<string>();

        return AreRequestsConnectedDFS(source, destination, visited);
    }

    private bool AreRequestsConnectedDFS(ServiceRequest source, ServiceRequest destination, HashSet<string> visited)
    {
        // Base case: if the source and destination are the same
        if (source == destination)
        {
            return true;
        }

        // Mark the current node as visited
        if (visited.Contains(source.ServiceRequestID))
        {
            return false;
        }

        visited.Add(source.ServiceRequestID);

        // Recursively check all dependencies
        foreach (var dependency in source.Dependencies)
        {
            if (AreRequestsConnectedDFS(dependency, destination, visited))
            {
                return true;
            }
        }

        return false;
    }

}
