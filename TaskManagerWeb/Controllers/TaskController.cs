using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManagerModel;
using TaskManagerBL;

namespace TaskManagerWeb.Controllers
{
    public class TaskController : ApiController
    {
        TaskBL tmBL = new TaskBL();

        // POST api/<controller> 
        public HttpResponseMessage Post([FromBody]TaskTableData taskData)
        {
            try
            {
                tmBL.AddTask(taskData);
                return Request.CreateResponse(HttpStatusCode.OK, "success");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, tmBL.GetTasks());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, tmBL.GetTask(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int id, [FromBody]TaskTableData taskData)
        {
            try
            {
                tmBL.UpdateTask(id,taskData);
                return Request.CreateResponse(HttpStatusCode.OK, "success");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                tmBL.DeleteTask(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Success");
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }

        }
    }
}
