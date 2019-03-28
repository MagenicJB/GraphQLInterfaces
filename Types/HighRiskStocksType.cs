using GraphQL.Types;
using GraphQLCore.Interfaces;
using GraphQLCore.Models;

namespace GraphQLCore.Types
{
    public class HighRiskStocksType : ObjectGraphType<HighRiskStocksModel>
    {
        public HighRiskStocksType()
        {
            Name="HighRiskStocks";
            Field(h => h.Risk, nullable: true).Description("adsgdsag");
            Interface<RiskStocksInterface>();
        }
    }
}