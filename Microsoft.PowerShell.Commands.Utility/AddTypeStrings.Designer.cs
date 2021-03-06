﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerShell.Commands.Utility {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AddTypeStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AddTypeStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerShell.Commands.Utility.AddTypeStrings", typeof(AddTypeStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. The assembly name {0} matches both {1} and {2}..
        /// </summary>
        public static string AmbiguousAssemblyName {
            get {
                return ResourceManager.GetString("AmbiguousAssemblyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. One or more required assemblies are missing..
        /// </summary>
        public static string AssemblyLoadErrors {
            get {
                return ResourceManager.GetString("AssemblyLoadErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. The assembly &apos;{0}&apos; could not be found..
        /// </summary>
        public static string AssemblyNotFound {
            get {
                return ResourceManager.GetString("AssemblyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. Definition of new types is not supported in this language mode..
        /// </summary>
        public static string CannotDefineNewType {
            get {
                return ResourceManager.GetString("CannotDefineNewType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}({1}) : {2}.
        /// </summary>
        public static string CompilationErrorFormat {
            get {
                return ResourceManager.GetString("CompilationErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. There were compilation errors..
        /// </summary>
        public static string CompilerErrors {
            get {
                return ResourceManager.GetString("CompilerErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type due to the following exception: {0}. Verify that version {1} of the Microsoft .NET Framework is installed. On 64-bit versions of Windows, the WOW64 component is also required..
        /// </summary>
        public static string CompilerErrorWithCSC {
            get {
                return ResourceManager.GetString("CompilerErrorWithCSC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. The &quot;{0}&quot; extension is not supported..
        /// </summary>
        public static string FileExtensionNotSupported {
            get {
                return ResourceManager.GetString("FileExtensionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. The -MemberDefinition parameter is not supported for this language..
        /// </summary>
        public static string FromMemberNotSupported {
            get {
                return ResourceManager.GetString("FromMemberNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. Specify only the Language or CodeDomProvider parameters..
        /// </summary>
        public static string LanguageAndProviderSpecified {
            get {
                return ResourceManager.GetString("LanguageAndProviderSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The generated type defines no public methods or properties..
        /// </summary>
        public static string MethodDefinitionNotPublic {
            get {
                return ResourceManager.GetString("MethodDefinitionNotPublic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. Input files must all have the same file extension..
        /// </summary>
        public static string MultipleExtensionsNotSupported {
            get {
                return ResourceManager.GetString("MultipleExtensionsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set output assembly. The path {0} did not resolve to a single file..
        /// </summary>
        public static string OutputAssemblyDidNotResolve {
            get {
                return ResourceManager.GetString("OutputAssemblyDidNotResolve", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. The OutputType parameter requires that the OutputAssembly parameter be specified..
        /// </summary>
        public static string OutputTypeRequiresOutputAssembly {
            get {
                return ResourceManager.GetString("OutputTypeRequiresOutputAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. The &apos;{0}&apos; language requires version {1} of the .NET Framework..
        /// </summary>
        public static string SpecialNetVersionRequired {
            get {
                return ResourceManager.GetString("SpecialNetVersionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. The type name &apos;{0}&apos; already exists..
        /// </summary>
        public static string TypeAlreadyExists {
            get {
                return ResourceManager.GetString("TypeAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The generated type is not public..
        /// </summary>
        public static string TypeDefinitionNotPublic {
            get {
                return ResourceManager.GetString("TypeDefinitionNotPublic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add type. The &apos;{0}&apos; parameter and the &apos;{1}&apos; parameter cannot both be specified..
        /// </summary>
        public static string WrongCompilerParameterCombination {
            get {
                return ResourceManager.GetString("WrongCompilerParameterCombination", resourceCulture);
            }
        }
    }
}
