using System.Collections.Generic;
using KanakketuppuApi_Core.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using KatavuccolCommon.Extensions;
using ParallelProcessors.DataContracts;

namespace KanakketuppuApiCore.Utilities
{
    public static class KanakketuppuApiCoreExtension
    {
        public static Status ToStatus(this List<ErrorMessage> value)
        {
            if (value.AnyWithNullCheck())
                return Status.Fail;
            return Status.Success;
        }

        public static List<ErrorMessage> ToErrorMessages(this List<ActionErrorMessage> value)
        {
            if (!value.AnyWithNullCheck())
                return null;
            var errorMessages = new List<ErrorMessage>();
            foreach (var actionErrorMessage in value)
            {
                errorMessages.Add(new ErrorMessage() { ErrorCode = actionErrorMessage.ErrorCode });
            }
            return errorMessages;
        }
    }
}