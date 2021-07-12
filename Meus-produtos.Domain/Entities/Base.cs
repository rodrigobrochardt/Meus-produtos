using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Domain.Entities
{
    public class Base
    {
        public int Id { get; set; }


        private List<ValidationResult> _validationsErros;


        public bool IsValid()
        {
            this._validationsErros = new List<ValidationResult>();
            var context = new ValidationContext(this);
            return Validator.TryValidateObject(this, context, _validationsErros, true);
        }

        public List<ValidationResult> GetValidationResults()
        {
            return _validationsErros;
        }
    }
}
