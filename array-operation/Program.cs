string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

/* Console.WriteLine("Sorted...");
Array.Sort(pallets); // mengurutkan
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets); // membalikkan urutan
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

// clear and resize
// clear string array element will be null and int will be 0
Array.Clear(pallets, 0, 2); // menghapus value
Console.WriteLine($"Clearing ... count : {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resize to add more elements
// membuat array menjadi 6 elements lalu menambahkan nialainya
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resize the array to remove elements
// membuat array menjadi hanya sepanjang 3 element, dimana element 3 terakhir lah yang di hilangkan
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}