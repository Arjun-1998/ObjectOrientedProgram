using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class StockManagement
    {

        List<Stock> stocklist = new List<Stock>();
        public StockManagement(List<Stock> stocks)
        {
            stocklist = stocks;
        }

        public void CalutateTotalValue()
        {
            foreach (Stock stock in stocklist)
            {
                stock.TotalPrice = stock.Price * stock.nostocks;
                Console.WriteLine($"{stock.Name} Has Total Price Of {stock.TotalPrice}");

            }

        }
    }
}

        