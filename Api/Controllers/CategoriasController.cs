﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entidades;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //devolver o json - utilizamos verbos http: get, delete, 
    public class CategoriasController : ControllerBase
    {
        private readonly Contexto db;
        public CategoriasController(Contexto contexto)
        {
            db = contexto;
        }
        //acesso aos dados
        [HttpGet]
        //retornar lista de categorias
        public List<Categoria> Get ()
        {
            return db.CATEGORIAS.ToList();

        }
        [HttpPost]
        public string Post(Categoria objeto)
        {
            db.CATEGORIAS.Add(objeto);
            db.SaveChanges();
            return "Adicionado com sucesso";
        }
    }
}
