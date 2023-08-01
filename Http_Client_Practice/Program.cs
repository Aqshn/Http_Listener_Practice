



using System.Text.Json;

while (true)
{
    var client = new HttpClient();
    Console.WriteLine("Write 1 To GetAll");
    Console.WriteLine("Write 2 Post");
    Console.WriteLine("Write 3 Delete");

    var str = Console.ReadLine();


    switch (str)
    {
        case "1":
            var message = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(@"https://www.google.com")
            };
            message.Headers.Add("Accept", "text/html");
            var response = await client.SendAsync(message);
            break;
    }
}



class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
}



