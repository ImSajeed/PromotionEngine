using System.Linq;

public static class ComputePromotion
{
    //returns PromotionID and count of promotions
    public static decimal GetTotalPrice(Order ord, Promotion prom)
    {
        
        //get count of promoted products in order
        var copp = ord.Products
            .GroupBy(x=> x.Id)
            .Where(grp=> prom.ProductInfo.Any(y=>grp.Key==y.Key && grp.Count()>=y.Value))
            .Select(grp=> grp.Count())
            .Sum();
        
        return copp;
    }
}