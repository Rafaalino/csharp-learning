string[] OrdersIDs = { "B123", "C234", "A345", "C159", "B177", "G3003", "C235", "B179" };

foreach (string fraudulentOrdersIDs in OrdersIDs)
{
    if (fraudulentOrdersIDs.StartsWith("B"))
    {
        Console.WriteLine($"The order ID {fraudulentOrdersIDs} is flagged as potentially fraudulent.");
    }
}