﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotLiquid.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotLiquid.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;assign&apos; tag - Valid syntax: assign [var] = [source].
        /// </summary>
        internal static string AssignTagSyntaxException {
            get {
                return ResourceManager.GetString("AssignTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error - This liquid context does not allow includes.
        /// </summary>
        internal static string BlankFileSystemDoesNotAllowIncludesException {
            get {
                return ResourceManager.GetString("BlankFileSystemDoesNotAllowIncludesException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Liquid Error - Block &apos;{0}&apos; already defined.
        /// </summary>
        internal static string BlockTagAlreadyDefinedException {
            get {
                return ResourceManager.GetString("BlockTagAlreadyDefinedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} tag does not expect else tag.
        /// </summary>
        internal static string BlockTagNoElseException {
            get {
                return ResourceManager.GetString("BlockTagNoElseException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;end&apos; is not a valid delimiter for {0} tags. Use {1}.
        /// </summary>
        internal static string BlockTagNoEndException {
            get {
                return ResourceManager.GetString("BlockTagNoEndException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} tag was never closed.
        /// </summary>
        internal static string BlockTagNotClosedException {
            get {
                return ResourceManager.GetString("BlockTagNotClosedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tag &apos;{0}&apos; was not properly terminated with regexp: {1}.
        /// </summary>
        internal static string BlockTagNotTerminatedException {
            get {
                return ResourceManager.GetString("BlockTagNotTerminatedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;block&apos; tag - Valid syntax: block [name].
        /// </summary>
        internal static string BlockTagSyntaxException {
            get {
                return ResourceManager.GetString("BlockTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown tag &apos;{0}&apos;.
        /// </summary>
        internal static string BlockUnknownTagException {
            get {
                return ResourceManager.GetString("BlockUnknownTagException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable &apos;{0}&apos; was not properly terminated with regexp: {1}.
        /// </summary>
        internal static string BlockVariableNotTerminatedException {
            get {
                return ResourceManager.GetString("BlockVariableNotTerminatedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;capture&apos; tag - Valid syntax: capture [var].
        /// </summary>
        internal static string CaptureTagSyntaxException {
            get {
                return ResourceManager.GetString("CaptureTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;case&apos; tag - Valid else condition: {{% else %}} (no parameters).
        /// </summary>
        internal static string CaseTagElseSyntaxException {
            get {
                return ResourceManager.GetString("CaseTagElseSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;case&apos; tag - Valid syntax: case [condition].
        /// </summary>
        internal static string CaseTagSyntaxException {
            get {
                return ResourceManager.GetString("CaseTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;case&apos; tag - Valid when condition: {{% when [condition] [or condition2...] %}}.
        /// </summary>
        internal static string CaseTagWhenSyntaxException {
            get {
                return ResourceManager.GetString("CaseTagWhenSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown operator {0}.
        /// </summary>
        internal static string ConditionUnknownOperatorException {
            get {
                return ResourceManager.GetString("ConditionUnknownOperatorException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Liquid error: {0}.
        /// </summary>
        internal static string ContextLiquidError {
            get {
                return ResourceManager.GetString("ContextLiquidError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Liquid syntax error: {0}.
        /// </summary>
        internal static string ContextLiquidSyntaxError {
            get {
                return ResourceManager.GetString("ContextLiquidSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object &apos;{0}&apos; is invalid because it is neither a built-in type nor implements ILiquidizable.
        /// </summary>
        internal static string ContextObjectInvalidException {
            get {
                return ResourceManager.GetString("ContextObjectInvalidException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nesting too deep.
        /// </summary>
        internal static string ContextStackException {
            get {
                return ResourceManager.GetString("ContextStackException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;cycle&apos; tag - Valid syntax: cycle [name :] var [, var2, var3 ...].
        /// </summary>
        internal static string CycleTagSyntaxException {
            get {
                return ResourceManager.GetString("CycleTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing property. Did you mean &apos;{0}&apos;?.
        /// </summary>
        internal static string DropWrongNamingConventionMessage {
            get {
                return ResourceManager.GetString("DropWrongNamingConventionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Liquid Error - &apos;extends&apos; tag can be used only once.
        /// </summary>
        internal static string ExtendsTagCanBeUsedOneException {
            get {
                return ResourceManager.GetString("ExtendsTagCanBeUsedOneException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Liquid Error - &apos;extends&apos; must be the first tag in an extending template.
        /// </summary>
        internal static string ExtendsTagMustBeFirstTagException {
            get {
                return ResourceManager.GetString("ExtendsTagMustBeFirstTagException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;extends&apos; tag - Valid syntax: extends [template].
        /// </summary>
        internal static string ExtendsTagSyntaxException {
            get {
                return ResourceManager.GetString("ExtendsTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Liquid Error - Only &apos;comment&apos; and &apos;block&apos; tags are allowed in an extending template.
        /// </summary>
        internal static string ExtendsTagUnallowedTagsException {
            get {
                return ResourceManager.GetString("ExtendsTagUnallowedTagsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;for&apos; tag - Valid syntax: for [item] in [collection].
        /// </summary>
        internal static string ForTagSyntaxException {
            get {
                return ResourceManager.GetString("ForTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;if&apos; tag - Valid syntax: if [expression].
        /// </summary>
        internal static string IfTagSyntaxException {
            get {
                return ResourceManager.GetString("IfTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;include&apos; tag - Valid syntax: include [template].
        /// </summary>
        internal static string IncludeTagSyntaxException {
            get {
                return ResourceManager.GetString("IncludeTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error - Illegal template name &apos;{0}&apos;.
        /// </summary>
        internal static string LocalFileSystemIllegalTemplateNameException {
            get {
                return ResourceManager.GetString("LocalFileSystemIllegalTemplateNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error - Illegal template path &apos;{0}&apos;.
        /// </summary>
        internal static string LocalFileSystemIllegalTemplatePathException {
            get {
                return ResourceManager.GetString("LocalFileSystemIllegalTemplatePathException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error - No such template &apos;{0}&apos;.
        /// </summary>
        internal static string LocalFileSystemTemplateNotFoundException {
            get {
                return ResourceManager.GetString("LocalFileSystemTemplateNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error - Filter &apos;{0}&apos; does not have a default value for &apos;{1}&apos; and no value was supplied.
        /// </summary>
        internal static string StrainerFilterHasNoValueException {
            get {
                return ResourceManager.GetString("StrainerFilterHasNoValueException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;tablerow&apos; tag - Valid syntax: tablerow [item] in [collection] cols=[number].
        /// </summary>
        internal static string TableRowTagSyntaxException {
            get {
                return ResourceManager.GetString("TableRowTagSyntaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error - Filter &apos;{0}&apos; in &apos;{1}&apos; could not be found..
        /// </summary>
        internal static string VariableFilterNotFoundException {
            get {
                return ResourceManager.GetString("VariableFilterNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to key could not be found.
        /// </summary>
        internal static string WeakTableKeyNotFoundException {
            get {
                return ResourceManager.GetString("WeakTableKeyNotFoundException", resourceCulture);
            }
        }
    }
}
