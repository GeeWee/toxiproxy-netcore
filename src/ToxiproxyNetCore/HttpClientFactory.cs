﻿using System;
using System.Net.Http;

namespace Toxiproxy.Net
{
    /// <summary>
    /// The factory class to create preconfigured HttoClient
    /// </summary>
    /// <seealso cref="Toxiproxy.Net.IHttpClientFactory" />
    internal class HttpClientFactory : IHttpClientFactory
    {
        private readonly Uri _baseUrl;

        public HttpClientFactory(Uri baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public Uri BaseUrl => _baseUrl;

        public HttpClient Create()
        {
            var client = new HttpClient {BaseAddress = _baseUrl};
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            return client;
        }
    }

    public interface IHttpClientFactory
    {
        Uri BaseUrl { get; }
        HttpClient Create();
    }
}
