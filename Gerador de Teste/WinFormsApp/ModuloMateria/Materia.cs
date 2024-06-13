﻿using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Modulo_disciplina;

namespace WinFormsApp.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; } 
        public string Serie { get; set; } 

        public Materia(string nome, Disciplina disciplina, string serie)
        {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome?.Trim()))
                erros.Add("O campo \"Nome\" é obrigatório");
            if (string.IsNullOrEmpty(Serie?.Trim()))
                erros.Add("O campo \"Serie\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia novaMateria = (Materia)novoRegistro;

            Nome = novaMateria.Nome;
            Disciplina = novaMateria.Disciplina;
            Serie = novaMateria.Serie;
        }

        public override string ToString()
        {
            return $"Materias: {Nome}, Disciplina: {Disciplina.Nome}, Serie: {Serie}";
        }
        

    }
}
