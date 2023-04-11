using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audaz
{
    public class FareService
    {
        private Repository _repository = new Repository();

        public void Create(Fare fare)
        {
            var existingFares = GetFaresByOperator(fare.Id);

            if (existingFares.Count > 0)
            {
                throw new Exception("Já existe uma tarifa ativa com este valor para esta operadora nos últimos seis meses.");
            }

            _repository.Insert(fare); 
        }

        public void Update(Fare fare)
        {
            _repository.Update(fare);
        }

        public Fare GetFareById(Guid fareId)
        {
            var fare = _repository.GetById<Fare>(fareId);
            return fare;
        }
        public List<Fare> GetFaresByOperator(Guid operatorId)
        {
            //Verifica se Status é == 1
            //Verfica se foi criado nos ultimo 6 meses
            //Verifica se o valor é igual
            var lastSixMonths = DateTime.Today.AddMonths(-6);
            return _repository.GetAll<Fare>()
                .Where(f => f.Value == f.Value && f.Status == 1 && f.CreatedAt >= lastSixMonths)
                .ToList();
        }
        public List<Fare> GetFares()
        {
            var fares = _repository.GetAll<Fare>();
            return fares;
        }
    }
}
