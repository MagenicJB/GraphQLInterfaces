using GraphQLCore.Interfaces;

namespace GraphQLCore.Models
{    
    
    public class LowRiskStocksModel : RiskStocks
    {
        public string Minimum { get; set; }
    }

}