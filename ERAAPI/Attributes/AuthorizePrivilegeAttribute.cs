using System;

namespace ERAAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorizePrivilegeAttribute : Attribute
    {
        public string FormName { get; }
        public string Action { get; }

        public AuthorizePrivilegeAttribute(string formName, string action)
        {
            FormName = formName;
            Action = action;
        }
    }
}
