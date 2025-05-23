﻿using AplicativoDesk.Model;
using System.Net;
using System.Text;
using Micro_OndasAPI.Models.Usuario;
using Newtonsoft.Json;

namespace AplicativoDesk.Persistencia
{
    public class CadastrarPersistencia
    {

        public RetornoPadraoModel Inserir(UsuarioModel data, out HttpStatusCode codehttp)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(Configuracoes.url + "usuario/Criar");
                request.Method = "POST";
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                string jsonString = JsonConvert.SerializeObject(data);
                byte[] byteArray = Encoding.UTF8.GetBytes(jsonString);

                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;

                using (var dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                try
                {
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        codehttp = response.StatusCode;

                        using (var responseStream = response.GetResponseStream())
                        using (var reader = new StreamReader(responseStream))
                        {
                            var responseFromServer = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<RetornoPadraoModel>(responseFromServer);
                        }
                    }
                }
                catch (WebException we)
                {
                    if (we.Response is HttpWebResponse errorResponse)
                    {
                        codehttp = errorResponse.StatusCode;

                        using (var responseStream = errorResponse.GetResponseStream())
                        using (var reader = new StreamReader(responseStream))
                        {
                            var responseFromServer = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<RetornoPadraoModel>(responseFromServer);
                        }
                    }
                    else
                    {
                        codehttp = HttpStatusCode.ServiceUnavailable;
                        return new RetornoPadraoModel
                        {
                            Data = null,
                            Mensagem = we.Message,
                            Status = false
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                codehttp = HttpStatusCode.InternalServerError;
                return new RetornoPadraoModel
                {
                    Data = null,
                    Mensagem = ex.Message,
                    Status = false
                };
            }
        }

        public RetornoPadraoModel ValidarLogin(UsuarioModel data, out HttpStatusCode codehttp)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(Configuracoes.url + "usuario/Login");
                request.Method = "POST";
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                string jsonString = JsonConvert.SerializeObject(data);
                byte[] byteArray = Encoding.UTF8.GetBytes(jsonString);

                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;

                using (var dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                try
                {
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        codehttp = response.StatusCode;

                        using (var responseStream = response.GetResponseStream())
                        using (var reader = new StreamReader(responseStream))
                        {
                            var responseFromServer = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<RetornoPadraoModel>(responseFromServer);
                        }
                    }
                }
                catch (WebException we)
                {
                    if (we.Response is HttpWebResponse errorResponse)
                    {
                        codehttp = errorResponse.StatusCode;

                        using (var responseStream = errorResponse.GetResponseStream())
                        using (var reader = new StreamReader(responseStream))
                        {
                            var responseFromServer = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<RetornoPadraoModel>(responseFromServer);
                        }
                    }
                    else
                    {
                        codehttp = HttpStatusCode.ServiceUnavailable;
                        return new RetornoPadraoModel
                        {
                            Data = null,
                            Mensagem = we.Message,
                            Status = false
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                codehttp = HttpStatusCode.InternalServerError;
                return new RetornoPadraoModel
                {
                    Data = null,
                    Mensagem = ex.Message,
                    Status = false
                };
            }
        }

    }
}