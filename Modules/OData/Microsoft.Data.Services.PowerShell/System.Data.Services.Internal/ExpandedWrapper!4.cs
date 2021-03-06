namespace System.Data.Services.Internal
{
    using System;
    using System.ComponentModel;
    using System.Data.Services;
    using System.Runtime.CompilerServices;

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class ExpandedWrapper<TExpandedElement, TProperty0, TProperty1, TProperty2> : ExpandedWrapper<TExpandedElement>
    {
        protected override object InternalGetExpandedPropertyValue(int nameIndex)
        {
            if (nameIndex == 0)
            {
                return this.ProjectedProperty0;
            }
            if (nameIndex == 1)
            {
                return this.ProjectedProperty1;
            }
            if (nameIndex != 2)
            {
                throw Error.NotSupported();
            }
            return this.ProjectedProperty2;
        }

        public TProperty0 ProjectedProperty0 { get; set; }

        public TProperty1 ProjectedProperty1 { get; set; }

        public TProperty2 ProjectedProperty2 { get; set; }
    }
}

