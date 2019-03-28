using GraphQL;
using GraphQL.Types;
using GraphQLCore.Queries;

namespace GraphQLCore.Models
{
    public class InvestorPortfolioSchema : Schema
    {
        public InvestorPortfolioSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<InvestorPortfolioTypeQuery>();
        }
    }
}


 