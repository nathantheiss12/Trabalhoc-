﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class TarefaController : Controller
    {
        // GET: Tarefa
        public ActionResult Index()
        {
            return View();
        }
    }
}