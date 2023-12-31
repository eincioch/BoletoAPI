﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BoletoAPI.Application.DTOs
{
    public class ContaBancariaDTO
    {
        #region Propriedades

        [Key]
        [DisplayName("Conta bancária Id")]
        public int ContaBancariaDTOId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Agencia { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Conta { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string CarteiraPadrao { get; set; } = string.Empty;

        #endregion Propriedades
    }
}