using GraphQL.Types;
using GraphQLCore.Enums;
using GraphQLCore.Interfaces;
using GraphQLCore.Models;
using GraphQLCore.Types;

namespace GraphQLCore.Queries
{
    public class InvestorPortfolioTypeQuery : ObjectGraphType
    {
        public InvestorPortfolioTypeQuery()
        {
            
            Field<RiskStocksInterface>(
                "riskStocks",
                arguments: new QueryArguments(new QueryArgument<StockRiskEnum> { Name = "risktype" }),
                resolve: context => 
                    {
                        var risklevel = context.GetArgument<RiskLevels>("risktype");
                        
                            return new HighRiskStocksModel()
                            {
                                ID=1001,
                                StockID=234,
                                Name="adf",
                                NYSE="AAA",
                                Amount="3245432",
                                Risk="LOW"
                            };

                    });


        }
    }
}