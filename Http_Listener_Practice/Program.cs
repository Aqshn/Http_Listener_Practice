using Http_Listener_Practice;
using System.Net;

var users = new List<User>
{
    new User{Id=1,Name="Aqsin",Surname="Humbatov"},
};



var listener = new HttpListener();



listener.Prefixes.Add(@"http://localhost:27001/");



listener.Start();



while (true)
{
    var context = listener.GetContext();
    var request = context.Request;
    var response = context.Response;
    if(request.HttpMethod == HttpMethod.Get.ToString())
    {
        foreach (var item in users)
        {
            item.ToString();
        }
    }
    else if(request.HttpMethod == HttpMethod.Post.ToString())
    {
        request.HttpMethod.
    }
}








