﻿using System.Net.Http;
using System.Threading.Tasks;
using App.Metrics;
using AspNet.Metrics.Facts.Integration.Startup;
using Xunit;
using FluentAssertions;

namespace AspNet.Metrics.Facts.Integration.Middleware
{
    public class RequestTimerMiddlewareTests : IClassFixture<MetricsHostTestFixture<DefaultTestStartup>>
    {
        public RequestTimerMiddlewareTests(MetricsHostTestFixture<DefaultTestStartup> fixture)
        {
            Client = fixture.Client;
            Context = fixture.Context;
        }

        public HttpClient Client { get; }

        public IMetrics Context { get; }

        [Fact]
        public async Task record_request_times()
        {
            await Client.GetAsync("/api/test/300ms");
            await Client.GetAsync("/api/test/300ms");
            await Client.GetAsync("/api/test/30ms");

            var metrics = await Context.Advanced.DataManager.GetContextAsync("Application.WebRequests");

            var timer = metrics.TimerValueFor("Web Requests");
            timer.Histogram.Min.Should().Be(30);
            timer.Histogram.Max.Should().Be(300);
            timer.TotalTime.Should().Be(630);
        }
    }
}