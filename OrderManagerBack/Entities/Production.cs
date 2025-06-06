﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Numerics;
using OrderManagerBack.Dto;
using OrderManagerBack.Models;

namespace OrderManagerBack.Entities
{
    [Table("Production")]
    public class Production
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Essa opção satizfaz o requisito de "IDENTITY(1,1)".
        public long Id { get; set; }

        [Column(name: "Email", TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string Email { get; set; }

        public Order OrderObj { get; set; } // Simplifica para obter a ordem de produção e gera a mesma estrutura de tabela requisitada

        [Column(name: "Date", TypeName = "DATETIME")]
        public DateTime Date { get; set; }

        [Column(name: "Quantity", TypeName = "NUMERIC(18,2)")]
        public decimal Quantity { get; set; }

        public Material Material { get; set; } // Simplifica para obter o material e gera a mesma estrutura de tabela requisitada

        [Column(name: "CycleTime", TypeName = "NUMERIC(18,2)")]
        public decimal CycleTime { get; set; }

        public ProductionDto ToDto()
        {
            return new()
            {
                Order = OrderObj.OrderCode,
                Date = Date.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture),
                Quantity = Quantity,
                MaterialCode = Material.MaterialCode,
                CycleTime = CycleTime,
            };
        }
    }
}
