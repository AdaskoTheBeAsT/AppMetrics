// <copyright file="ThreadLocalLongAdderBenchMark.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using System;
using BenchmarkDotNet.Attributes;

namespace App.Metrics.Concurrency.Benchmarks.BenchmarkDotNetBenchmarks.Concurrency
{
    public sealed class ThreadLocalLongAdderBenchmark : DefaultBenchmarkBase, IDisposable
    {
        private ThreadLocalLongAdder _num;

        public override void Setup()
        {
            _num = new ThreadLocalLongAdder();
        }

        [Benchmark]
        public void Decrement()
        {
            _num.Decrement(1);
        }

        [Benchmark]
        public void Get()
        {
            // ReSharper disable UnusedVariable
            var x = _num.GetValue();
            // ReSharper restore UnusedVariable
        }

        [Benchmark]
        public void Increment()
        {
            _num.Increment(1);
        }

        public void Dispose()
        {
            _num?.Dispose();
        }
    }
}