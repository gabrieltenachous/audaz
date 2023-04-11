using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audaz
{
    public class FareController
    {
        private OperatorService _operatorService;
        private FareService FareService; 
        public FareController()
        {
            _operatorService = new OperatorService();
        }

        public void CreateFare(Fare fare, string operatorCode)
        {
            var selectedOperator = _operatorService.GetOperatorByCode(operatorCode); 
            if (selectedOperator != null)
            {
                fare.OperatorId = selectedOperator.Id; 
                FareService.Create(fare);
            }
        }
    }
}
