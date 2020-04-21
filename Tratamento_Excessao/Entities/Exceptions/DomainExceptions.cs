using System;

namespace Tratamento_Excessao.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public string Error { get; protected set; }

        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
