using System.Collections.Generic;
using KanakketuppuApi_Core.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using KatavuccolCommon.Extensions;

namespace KanakketuppuApiCore.Utility
{
    public static class KanakketuppuApiCoreUtility
    {
        public static Status ToStatus(this List<ErrorMessage> value)
        {
            if (value.AnyWithNullCheck())
                return Status.Fail;
            return Status.Success;
        }
    }
}