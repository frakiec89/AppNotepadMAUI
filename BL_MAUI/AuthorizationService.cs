using AppNotepadMAUI.Model;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace BL_MAUI
{
    public class AuthorizationService
    {
        public User GetUser(string login, string password)
        {
            try
            {
              var usRequst = new UserRequstcs() { login = login , password= password};
                var jsonContent = JsonConvert.SerializeObject(usRequst);
                string respons =  Post("http://192.168.59.37:81/api/Authorization/logIn", jsonContent);
                return JsonConvert.DeserializeObject<User>(respons);
            }
            catch (Exception ex)
            {
                throw  ex;
            }
        }

        public static string Post(string url, string content)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                byte[] contentBytes = Encoding.UTF8.GetBytes(content);
                request.ContentLength = contentBytes.Length;
                using (Stream s = request.GetRequestStream())
                {
                    s.Write(contentBytes, 0, contentBytes.Length);
                }
                string result = "";
                WebResponse response = request.GetResponse();
                using (StreamReader sr = new(response.GetResponseStream(), Encoding.UTF8))
                {
                    result = sr.ReadToEnd();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

    }
}
