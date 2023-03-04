using BarcodeExample.Classes;
namespace BarcodeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to barcode app!");
            // Barcode (item category --- > 3n   // item price     --- > 5n    // item number     --- > 5n)
            string Barcodes = @"0010020000001-0020050000002-0030040000003-0040150000013";
            string[] BarcodeArray = Barcodes.Split('-');

            Item OItem = new Item();
            List<Item> ListOfItems = new List<Item>();

            foreach (string xBarcode in BarcodeArray)
            {
                OItem = new Item();
                OItem.CategoryNumber = Convert.ToInt32(xBarcode.Substring(0, 3));
                OItem.ItemPrice = Convert.ToDecimal(xBarcode.Substring(3, 5));
                OItem.ItemNumber = Convert.ToInt32(xBarcode.Substring(8, 5));
                OItem.ItemName = Console.ReadLine();//from user

                ListOfItems.Add(OItem);
            }

            string NewBarcodes = string.Empty;
            foreach (var x in ListOfItems)
            {
                NewBarcodes += $"-{OItem.GetFormatedCategoryNumber(x.CategoryNumber)}-{OItem.GetFormatedPriceNumber(x.ItemPrice)}-{OItem.GetFormatedItemNumber(x.ItemNumber)} \n {OItem.ItemName}";
            }


        }
    }
}