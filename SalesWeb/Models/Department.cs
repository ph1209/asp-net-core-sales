/*
    CLASS: DEPARTMENT
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWeb.Models {
    public class Department {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

       
        
        /// <summary>
        /// CONSTRUTOR SEM ARGUMENTOS
        /// </summary>
        public Department() { }

      
        /// <summary>
        /// CONSTRUTOR COM ARGUMENTOS
        /// Não atribuir atributos que são seleções
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Department(int id, string name) {
            Id = id;
            Name = name;
        }
        
        /// <summary>
        /// ADICIONA UM NOVO VENDEDOR
        /// </summary>
        /// <param name="seller"></param>
        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }

        /// <summary>
        /// RETORNA O TOTAL DE VENDAS DE TODOS OS VENDEDORES
        /// </summary>
        /// <param name="initial"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public double TotalSales(DateTime initial, DateTime final ) {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
