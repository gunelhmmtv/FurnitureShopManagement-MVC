using FS.CoreLayer.Classes;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace FS.CoreLayer.Extentions
{
    public static class ValidationExtention
    {
        public static ICollection<ResponseValidationResult> ToResponseValidationResults(this ValidationResult validationResult)
        {
            ICollection<ResponseValidationResult> responseValidationResults = [];

            foreach (var item in validationResult.Errors)
            {
                responseValidationResults.Add(new()
                {
                    ErrorMessage = item.ErrorMessage,
                    PropertyName = item.PropertyName,
                });
            }

            return responseValidationResults;
        }
    }
}
