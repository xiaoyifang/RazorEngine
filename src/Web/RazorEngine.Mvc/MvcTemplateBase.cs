namespace RazorEngine.Mvc
{
    using System;
    using System.Web;
    using System.Web.Mvc;

    using Templating;

    /// <summary>
    /// Provides a base implementation of an MVC-compatible template.
    /// </summary>
    public abstract class MvcTemplateBase<T> : MvcTemplateBase
    {
        public T Model { get; set; }
    }
}