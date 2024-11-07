using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace CapaPresentacion
{
    public class FacturacionApi
    {
        private readonly string token;

        public FacturacionApi(string token)
        {
            this.token = token;
        }

        // Método para obtener respuesta JSON de SUNAT
        public dynamic PostForJsonResponse(string url, object body)
        {
            string responseContent = string.Empty;
            try
            {
                string jsonBody = JsonConvert.SerializeObject(body);
                var response = SendRequest(url, jsonBody);

                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    responseContent = reader.ReadToEnd();
                }

                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    throw new Exception("La respuesta del servidor está vacía.");
                }

                return JsonConvert.DeserializeObject<dynamic>(responseContent);
            }
            catch (Exception ex)
            {
                HandleException(ex, responseContent);
                throw;
            }
        }

        // Método para generar y obtener XML
        public string PostForXmlResponse(string url, object body)
        {
            string responseContent = string.Empty;
            try
            {
                string jsonBody = JsonConvert.SerializeObject(body);
                var response = SendRequest(url, jsonBody);

                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    responseContent = reader.ReadToEnd();
                }

                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    throw new Exception("La respuesta del servidor está vacía.");
                }

                return responseContent;  // Retorna el XML como string
            }
            catch (Exception ex)
            {
                HandleException(ex, responseContent);
                throw;
            }
        }

        // Método para guardar PDF si es necesario
        public string PostForPdfResponse(string url, object body)
        {
            try
            {
                string jsonBody = JsonConvert.SerializeObject(body);
                var response = SendRequest(url, jsonBody);

                if (response.ContentType == "application/pdf")
                {
                    string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Factura.pdf");
                    using (Stream responseStream = response.GetResponseStream())
                    using (var fileStream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write))
                    {
                        responseStream.CopyTo(fileStream);
                    }
                    return pdfPath;
                }

                throw new Exception("La respuesta no es un PDF válido.");
            }
            catch (Exception ex)
            {
                HandleException(ex, string.Empty);
                throw;
            }
        }

        private HttpWebResponse SendRequest(string url, string jsonBody)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers["Authorization"] = $"Bearer {token}";
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Proxy = null;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(jsonBody);
                streamWriter.Flush();
            }

            return (HttpWebResponse)request.GetResponse();
        }

        private void HandleException(Exception ex, string responseContent)
        {
            if (ex is WebException webEx)
            {
                using (var stream = webEx.Response?.GetResponseStream())
                using (var reader = new StreamReader(stream ?? Stream.Null))
                {
                    responseContent = reader.ReadToEnd();
                }
                throw new Exception($"Error de red: {webEx.Message}. Respuesta del servidor: {responseContent}");
            }
            else if (ex is JsonException jsonEx)
            {
                throw new Exception($"Error al deserializar la respuesta JSON: {jsonEx.Message}");
            }
            else
            {
                throw new Exception($"Error inesperado: {ex.Message}. Contenido de la respuesta: {responseContent}");
            }
        }
    }
}
