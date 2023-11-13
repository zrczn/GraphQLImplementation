using GraphQLImplementation.Models;

namespace GraphQLImplementation.ApplicationDatabaseContext
{
    public class Query
    {
        public IQueryable<Agent> GetAgents 
            => new List<Agent>().AsQueryable();
    }
}
