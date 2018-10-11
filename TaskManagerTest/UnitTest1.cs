using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagerModel;
//using TaskManagerWeb;
using TaskManagerWeb.Controllers;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;

namespace TaskManagerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAddTask()
        {
            TaskController tmController = new TaskController()
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            TaskTableData taskData = new TaskTableData()
            {
                Task_ID = 1,
                Parent_ID = 0,
                Task = "TestTask",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(5),
                Priority = 15,
                Status = true
            };
            string ExpectedResult = "OK";
            HttpResponseMessage actualResponse = tmController.Post(taskData);
            string ActualResult = actualResponse.StatusCode.ToString();
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void TestMethodGetTasks()
        {
            TaskController tmController = new TaskController()
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
            List<TaskTableData> lstTaskData = new List<TaskTableData>()
            {
                new TaskTableData()
                {
                Task_ID = 1,
                Parent_ID = 0,
                Task = "Test4",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(5),
                Priority = 15,
                Status = true
                },
                new TaskTableData()
                {
                Task_ID = 2,
                Parent_ID = 0,
                Task = "Test1",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(5),
                Priority = 15,
                Status = true
                },
                new TaskTableData()
                {
                Task_ID = 3,
                Parent_ID = 0,
                Task = "TestTask",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(5),
                Priority = 15,
                Status = true
                },
            };

            string ExpectedResult = "OK";
            HttpResponseMessage actualResponse = tmController.Get();
            string ActualResult = actualResponse.StatusCode.ToString();
            Assert.AreEqual(ExpectedResult, ActualResult);

            List<TaskTableData> responseData;
            actualResponse.TryGetContentValue(out responseData);
            Assert.AreEqual(lstTaskData.Count, responseData.Count);
        }

        [TestMethod]
        public void TestMethodGetTask()
        {
            TaskController tmController = new TaskController()
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
            TaskTableData taskData = new TaskTableData()
            {
                Task_ID = 1,
                Parent_ID = 0,
                Task = "Task2",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(5),
                Priority = 15,
                Status = true
            };

            string ExpectedResult = "OK";
            HttpResponseMessage actualResponse = tmController.Get(1);
            string ActualResult = actualResponse.StatusCode.ToString();
            Assert.AreEqual(ExpectedResult, ActualResult);

            TaskTableData responseData;
            actualResponse.TryGetContentValue(out responseData);
            Assert.AreEqual(taskData.Task, responseData.Task);
        }

        [TestMethod]
        public void TestMethodUpdateTask()
        {
            TaskController tmController = new TaskController()
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
            TaskTableData taskData = new TaskTableData()
            {
                Task_ID = 3,
                Parent_ID = 0,
                Task = "Task3",
                Start_Date = DateTime.Now,
                End_Date = DateTime.Now.AddDays(5),
                Priority = 15,
                Status = true
            };

            string ExpectedResult = "OK";
            HttpResponseMessage actualResponse = tmController.Put(3, taskData);
            string ActualResult = actualResponse.StatusCode.ToString();
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void TestMethodDeleteTask()
        {
            TaskController tmController = new TaskController()
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            string ExpectedResult = "OK";
            HttpResponseMessage actualResponse = tmController.Delete(6);
            string ActualResult = actualResponse.StatusCode.ToString();
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
