
Console.Write("Hello, What is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Hello {userName} Now You can Ask Anythig....");
Model model = new Model();

while (true)
{
    Console.Write($"{userName} : ");
    string? msg = Console.ReadLine();
    if (msg != null){
        bool result = await model.SendRequest(msg);
        if (result){
            System.Console.WriteLine(model);
        }
        else{
            System.Console.WriteLine("Error with Ai Response....");
            break;
        }
    }
}
