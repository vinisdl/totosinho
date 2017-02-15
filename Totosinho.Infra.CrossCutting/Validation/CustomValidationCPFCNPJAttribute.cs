using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Totosinho.Infra.CrossCutting.Helper;

namespace Totosinho.Infra.CrossCutting.Validation
{
    public class CustomValidationCpfCnpjAttribute : ValidationAttribute
    {
        /// <summary>
        ///     Validação server
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return true;

            var valido = value.ToString().Length != 14
                ? ValidacaoCpfCnpjHelper.ValidaCpf(value.ToString())
                : ValidacaoCpfCnpjHelper.ValidaCnpj(value.ToString());

            return valido;
        }

        /// <summary>
        ///     Validação client
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
            ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = FormatErrorMessage(null),
                ValidationType = "customvalidationcpf"
            };
        }
    }
}