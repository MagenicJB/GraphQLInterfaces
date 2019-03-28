using GraphQL.Types;
using GraphQLCore.Interfaces;
using GraphQLCore.Models;

namespace GraphQLCore.Types
{
    public class LowRiskStocksType : ObjectGraphType<LowRiskStocksModel>
    {
        public LowRiskStocksType()
        {
            Name="LowRiskStocks";
            Interface<RiskStocksInterface>();
            Field(x => x.Minimum);   
        }
    }
}