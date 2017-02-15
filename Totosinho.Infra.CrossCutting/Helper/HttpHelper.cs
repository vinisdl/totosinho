using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Totosinho.Infra.CrossCutting.Helper
{
    public static class HttpHelper
    {
        public static bool TryPost(string cnpjServidor, string url, params string[] data)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));

                request.Timeout = Timeout.Infinite;
                request.Method = "POST";

                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers.Add("access_token", "kad1tx725aPNx877d2nngD3p5ByD368w");
                UTF8Encoding encoding = new System.Text.UTF8Encoding();
                byte[] bytes = encoding.GetBytes(string.Join("&", data));

                request.ContentLength = bytes.Length;

                using (var myStream = request.GetRequestStream())
                {
                    myStream.Write(bytes, 0, bytes.Length);
                    myStream.Close();
                }

                WebResponse resp = request.GetResponse();
                string resposta;
                using (var sr = new StreamReader(resp.GetResponseStream(), encoding))
                    resposta = sr.ReadToEnd();

                LogHelper.Info(string.Format("Resposta: {0}", resposta), cnpjServidor);
                LogHelper.Info(string.Format("Executado com sucesso Url: {0}", url), cnpjServidor);

                return true;
            }
            catch(Exception ex)
            {
                LogHelper.Fatal(ex, "Erro ao executar url para pagamento", url, cnpjServidor);
                return false;
            }
        }
    }
}
