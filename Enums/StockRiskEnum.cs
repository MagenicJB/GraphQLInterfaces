using GraphQL.Types;

namespace GraphQLCore.Enums
{
    public class StockRiskEnum : EnumerationGraphType
    {
        public StockRiskEnum()
        {
            Name = "StockRiskEnum";

            AddValue("HIGH", "High Risk Stock", 0);
            AddValue("LOW", "Low Risk Stock", 1);
        }
    }
}
