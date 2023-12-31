﻿using System.Text;
using Newtonsoft.Json;
using LivrariaWeb.Models;

namespace LivrariaWeb.Services;

public class ClienteApiService
{
    private readonly string ENDPOINT;
    private readonly HttpClient httpClient;

    public ClienteApiService(IConfiguration configuration)
    {
        ENDPOINT = configuration["AppConfig:EndPoints:Url_Api"] + "Cliente/";
        httpClient = new HttpClient
        {
            BaseAddress = new Uri(ENDPOINT)
        };
    }

    public async Task<List<ClienteViewModel>> RecuperarClientes()
    {
        List<ClienteViewModel> clientes = null;

        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(ENDPOINT);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                clientes = JsonConvert.DeserializeObject<List<ClienteViewModel>>(content);
            }

            return clientes;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<ClienteViewModel> RecuperarClientePeloId(int id)
    {
        try
        {
            ClienteViewModel result = null;

            string url = $"{ENDPOINT}{id}";

            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ClienteViewModel>(content);
            }

            return result;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<bool> CriandoCliente(ClienteViewModel cliente)
    {
        try
        {
            string json = JsonConvert.SerializeObject(cliente);
            byte[] buffer = Encoding.UTF8.GetBytes(json);
            ByteArrayContent byteArrayContent = new(buffer);
            byteArrayContent.Headers.ContentType =
                new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            string url = ENDPOINT;
            HttpResponseMessage responseMessage = await httpClient.PostAsync(url, byteArrayContent);
            return responseMessage.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
