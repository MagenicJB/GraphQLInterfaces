using System;
using GraphQL.Types;
using GraphQLCore.Models;
using GraphQLCore.Types;

namespace GraphQLCore.Interfaces
{

    public class RiskStocksInterface : InterfaceGraphType<RiskStocks>
    {
        public RiskStocksInterface()
        {
            Name = "RiskStocks";

            Field(x => x.ID);
            Field(x => x.StockID);
            Field(x => x.Name);
            Field(x => x.NYSE);
            Field(x => x.Amount);

        }
    }

}