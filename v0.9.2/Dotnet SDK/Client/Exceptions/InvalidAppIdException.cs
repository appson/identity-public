using System;
using System.Linq;
using Appson.Common.General.Validation;

namespace Appson.Identity.Client.Exceptions
{
    public class InvalidAppIdException : Exception
    {
        public InvalidAppIdException(ApiValidationResult response)
        {
            Response = response;
        }

        public ApiValidationResult Response { get; set; }

        public override string Message
        {
            get { return Response?.Errors?.Select(s => s.ErrorKey).FirstOrDefault(); }
        }
    }
}