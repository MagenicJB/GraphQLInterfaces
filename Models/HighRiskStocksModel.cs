using GraphQLCore.Interfaces;

namespace GraphQLCore.Models
{    
    
    public class HighRiskStocksModel : RiskStocks
    {
        public string Risk { get; set; }
    }

}