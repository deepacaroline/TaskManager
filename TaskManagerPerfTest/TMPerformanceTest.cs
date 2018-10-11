using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBench;
using TaskManagerWeb.Controllers;
using TaskManagerModel;
using System.Net.Http;
using System.Web.Http;

namespace TaskManagerPerfTest
{
    public class TMPerformanceTest
    {
        private Counter opCounter;
        private const string counterName = "counterName";

        [PerfSetup]
        public void SetUp(BenchmarkContext bmContext)
        {
            opCounter = bmContext.GetCounter(counterName);
        }

        [PerfBenchmark(NumberOfIterations =10,RunMode =RunMode.Throughput,RunTimeMilliseconds =1000,TestMode =TestMode.Measurement)]
        [CounterMeasurement(counterName)]
        public void BenchMarkMethod(BenchmarkContext bmContext)
        {
            var tmController = new TaskController()
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            List<TaskTableData> lstTaskData = new List<TaskTableData>();

                
        }

        
        
    }
}
