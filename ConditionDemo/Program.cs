int sayi1 = 15;
int sayi2 = 30;
int sayi3 = 3;

//Find the largest number
int largestNumber = sayi1;
if (largestNumber < sayi2)
{
    largestNumber = sayi2;
}
if (largestNumber < sayi3) {  largestNumber = sayi3; }
Console.WriteLine("Largest number is "+largestNumber);