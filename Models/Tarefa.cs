using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace To_Do_List.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public StatusTarefa Status { get; set; }
        public StatusTarefa Pendente = StatusTarefa.Pendente;
        public StatusTarefa Finalizado = StatusTarefa.Finalizado;
    }
}