using System;
using System.Web.Services;

[WebService(Namespace = "http://myservice-8.apphb.com/MyService.asmx")] // tempuri.org is the default, you should change this
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class MyService : System.Web.Services.WebService
{
	[WebMethod]
	public int Add(int a, int b)
	{
		return a+b;
	}
	
	[WebMethod(EnableSession = true)]
	public void setName(string name)
	{
		 Session["userName"] = name;
            
	}
	
	
	
	[WebMethod(EnableSession = true)]
	public string getName()
        {
            
            return (string)Session["userName"];
        }
	
}