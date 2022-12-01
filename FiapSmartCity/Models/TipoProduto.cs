﻿using System.ComponentModel.DataAnnotations;

namespace FiapSmartCity.Models
{
    public class TipoProduto
    {
        public int IdTipo { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória!")]
        [StringLength(50, ErrorMessage = "A descrição deve ter, no máximo, 50 caracteres")]
        [Display(Name = "Descrição:")]
        public String DescricaoTipo { get; set; }
        public bool Comercializado { get; set; }
    }
}