using System.Collections.Generic;

public class Promotion
{
    public int PromotionID  { get; set; }
    public Dictionary<string, int> ProductInfo { get; set; }
    public decimal PromoPrice  { get; set; }

    public Promotion(int promID, Dictionary<string, int> prodInfo, decimal pp)
    {
        this.PromotionID = promID;
        this.ProductInfo = prodInfo;
        this.PromoPrice = pp;
    }
}