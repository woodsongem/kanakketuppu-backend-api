using System.Collections.Generic;
using KanakketuppuApi_Core.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;

namespace KanakketuppuApiCore.DataContracts
{
    public class Result
    {
        public Status ResultStatus { get; set; }
        public List<ErrorMessage> ErrorMessages { get; set; }
    }
}