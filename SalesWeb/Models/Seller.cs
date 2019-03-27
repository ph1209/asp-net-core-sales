using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWeb.Models {
    public class Seller {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary{ get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        /// <summary>
        /// CONSTRUTOR SEM ARGUMENTOS
        /// </summary>
        public Seller() {}

        /// <summary>
        /// CONSTRUTOR COM ARGUMENTOS
        /// Não atribuir atributos que são seleções
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="birthDate"></param>
        /// <param name="baseSalary"></param>
        /// <param name="department"></param>
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        /// <summary>
        /// ADICIONA UMA NOVA VENDA
        /// </summary>
        /// <param name="sale_record"></param>
        public void AddSales(SalesRecord sale_record) {
            Sales.Add(sale_record);
        }

        /// <summary>
        /// REMOVE UMA VENDA
        /// </summary>
        /// <param name="sale_record"></param>
        public void RemoveSales(SalesRecord sale_record) {
            Sales.Remove(sale_record);
        }

        /// <summary>
        /// RETORNA TOTAL DE VENDAS DENTRO DE UM INTERVALO DE DATAS
        /// </summary>
        /// <param name="initial"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public double TotalSales(DateTime initial, DateTime final) {
            return Sales.Where(sale_record => sale_record.Date >= initial && sale_record.Date <= final)
                .Sum(sale_record => sale_record.Amount);
        }
    }
}
