using System.Collections;

string[] slumpad = File.ReadAllLines("siffror.txt");
var ordning = new int?[slumpad.Length];

foreach (string item in slumpad)
{
    var konverterad = int.Parse(item);

    for (int i = 0; i < ordning.Length; i++)
    {
        var temp = ordning[i];
        if(temp == null)
        {
            ordning[i] = konverterad;
            break;
        }
        if(konverterad < temp)
        {
            slump(i);
            ordning[i] = konverterad;
            break;
        }
    }
}

foreach (var item in ordning)
{
    Console.WriteLine(item);
}

 void slump(int fromIndex)
{
    var längd = ordning.Length -2;
    for (int i = längd; i >= fromIndex; i--)
    {
        var temp = ordning[i];
        ordning[i + 1] = temp; 
    }
}