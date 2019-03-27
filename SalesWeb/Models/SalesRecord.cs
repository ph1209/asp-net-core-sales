using SalesWeb.Models.Enums;
using System;

namespace SalesWeb.Models {
    public class SalesRecord {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        /// <summary>
        /// CONSTRUTOR SEM ARGUMENTOS
        /// </summary>
        public SalesRecord() { }

        /// <summary>
        /// CONSTRUTOR COM ARGUMENTOS
        /// Não atribuir atributos que são seleções
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="amount"></param>
        /// <param name="status"></param>
        /// <param name="seller"></param>
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller) {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
