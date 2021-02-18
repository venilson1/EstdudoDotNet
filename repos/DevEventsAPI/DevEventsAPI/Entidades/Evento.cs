﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEventsAPI.Entidades
{
    public class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        //Foreign Key
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}