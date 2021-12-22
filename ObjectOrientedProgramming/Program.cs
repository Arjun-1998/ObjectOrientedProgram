using ObjectOrientedProgramming;

List<Stock> stocks = new List<Stock>()
{
    new Stock()
    {
        Price = 20, Name = "Gold", nostocks  = 6, Symbol = "Gold.Pic"

    },
    new Stock()
    {
        Name = "Sliver", Price = 40, Symbol = "Sliver.coc", nostocks = 7
    }
};

StockManagement stockMangement = new StockManagement();
stockMangement.CalutateTotalValue(stocks);