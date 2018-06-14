﻿using System;
using System.Linq.Expressions;
using Bridge;
using OpenUI5Sharp;

namespace OpenUI5Sharp.Extensions
{
    [Namespace(false)]
    [FileName("openui5sharp.js")]
    public static class sapuimodelModelExtensions
    {
        /// <summary>
        /// Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
        /// </summary>
        /// <param name="model">the model to extend</param>
        /// <param name="pathExpression">the path/name of the property</param>
        /// <param name="oContext">the context if available to access the property value</param>
        /// <param name="absolutePath">true if the generated path should be absolute; false otherwise</param>
        /// <returns>Value the value of the property</returns>
        public static TValue getOriginalPropertyFor<TModel, TValue>(this sap.ui.model.Model<TModel> model, Expression<Func<TModel, TValue>> pathExpression, sap.ui.model.Context oContext, bool absolutePath = true)
        {
            string pref = absolutePath ? "/" : "";
            string sPropertyName = $"{pref}{ExpressionEvaluator.GetPath(pathExpression)}";
            return model.getOriginalProperty<TValue>(sPropertyName, oContext);
        }

        /// <summary>
        /// Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
        /// </summary>
        /// <param name="model">the model to extend</param>
        /// <param name="pathExpression">the path/name of the property</param>
        /// <param name="absolutePath">true if the generated path should be absolute; false otherwise</param>
        /// <returns>Value the value of the property</returns>
        public static TValue getOriginalPropertyFor<TModel, TValue>(this sap.ui.model.Model<TModel> model, Expression<Func<TModel, TValue>> pathExpression, bool absolutePath = true)
        {
            string pref = absolutePath ? "/" : "";
            string sPropertyName = $"{pref}{ExpressionEvaluator.GetPath(pathExpression)}";
            return model.getOriginalProperty<TValue>(sPropertyName);
        }

        /// <summary>
        /// Implement in inheriting classes
        /// </summary>
        /// <param name="model">the model to extend</param>
        /// <param name="pathExpression">the path to where to read the attribute value</param>
        /// <param name="oContext">the context with which the path should be resolved</param>
        /// <param name="absolutePath">true if the generated path should be absolute; false otherwise</param>
        /// <returns>Returns the value for the property with the given sPropertyName</returns>
        public static TValue getPropertyFor<TModel, TValue>(this sap.ui.model.Model<TModel> model, Expression<Func<TModel, TValue>> pathExpression, sap.ui.model.Context oContext, bool absolutePath = true)
        {
            string pref = absolutePath ? "/" : "";
            string sPropertyName = $"{pref}{ExpressionEvaluator.GetPath(pathExpression)}";
            return model.getProperty<TValue>(sPropertyName, oContext);
        }


        /// <summary>
        /// Implement in inheriting classes
        /// </summary>
        /// <param name="model">the model to extend</param>
        /// <param name="pathExpression">the path to where to read the attribute value</param>
        /// <param name="absolutePath">true if the generated path should be absolute; false otherwise</param>
        /// <returns>Returns the value for the property with the given sPropertyName</returns>
        public static TValue getPropertyFor<TModel, TValue>(this sap.ui.model.Model<TModel> model, Expression<Func<TModel, TValue>> pathExpression, bool absolutePath = true)
        {
            string pref = absolutePath ? "/" : "";
            string sPropertyName = $"{pref}{ExpressionEvaluator.GetPath(pathExpression)}";
            return model.getProperty<TValue>(sPropertyName);
        }

        /// <summary>
        /// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
        /// </summary>
        /// <param name="model">the model to extend</param>
        /// <param name="pathExpression">path of the property to set</param>
        /// <param name="value">value to set the property to</param>
        /// <param name="oContext">the context which will be used to set the property</param>
        /// <param name="bAsyncUpdate">whether to update other bindings dependent on this property asynchronously</param>
        /// <param name="absolutePath">true if the generated path should be absolute; false otherwise</param>
        /// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
        public static bool setPropertyFor<TModel, TValue>(this sap.ui.model.Model<TModel> model, Expression<Func<TModel, TValue>> pathExpression, TValue value, sap.ui.model.Context oContext, bool bAsyncUpdate, bool absolutePath = true)
        {
            string pref = absolutePath ? "/" : "";
            string sPropertyName = $"{pref}{ExpressionEvaluator.GetPath(pathExpression)}";
            return model.setProperty(sPropertyName, value, oContext, bAsyncUpdate);
        }

        /// <summary>
        /// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
        /// </summary>
        /// <param name="model">the model to extend</param>
        /// <param name="pathExpression">path of the property to set</param>
        /// <param name="value">value to set the property to</param>
        /// <param name="oContext">the context which will be used to set the property</param>
        /// <param name="absolutePath">true if the generated path should be absolute; false otherwise</param>
        /// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
        public static bool setPropertyFor<TModel, TValue>(this sap.ui.model.Model<TModel> model, Expression<Func<TModel, TValue>> pathExpression, TValue value, sap.ui.model.Context oContext, bool absolutePath = true)
        {
            string pref = absolutePath ? "/" : "";
            string sPropertyName = $"{pref}{ExpressionEvaluator.GetPath(pathExpression)}";
            return model.setProperty(sPropertyName, value, oContext);
        }

        /// <summary>
        /// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
        /// </summary>
        /// <param name="model">the model to extend</param>
        /// <param name="pathExpression">path of the property to set</param>
        /// <param name="value">value to set the property to</param>
        /// <param name="absolutePath">true if the generated path should be absolute; false otherwise</param>
        /// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
        public static bool setPropertyFor<TModel, TValue>(this sap.ui.model.Model<TModel> model, Expression<Func<TModel, TValue>> pathExpression, TValue value, bool absolutePath = true)
        {
            string pref = absolutePath ? "/" : "";
            string sPropertyName = $"{pref}{ExpressionEvaluator.GetPath(pathExpression)}";
            return model.setProperty(sPropertyName, value);
        }
    }

    [Namespace(false)]
    [FileName("openui5sharp.js")]
    // TODO: getObject/getPath
    public static class sapuimodelContextExtensions
    {
        /// <summary>
        /// Gets the property with the given relative binding path
        /// </summary>
        /// <param name="context">the context to extend</param>
        /// <param name="pathExpression">the binding path</param>
        /// <param name="absolutePath">true if the generated path should be absolute; false otherwise</param>
        /// <returns>the property value</returns>
        public static TValue getPropertyFor<TModel, TValue>(this sap.ui.model.Context<TModel> context, Expression<Func<TModel, TValue>> pathExpression, bool absolutePath = true)
        {
            string pref = absolutePath ? "/" : "";
            string sPropertyName = $"{pref}{ExpressionEvaluator.GetPath(pathExpression)}";
            return context.getProperty<TValue>(sPropertyName);
        }
    }
}

namespace OpenUI5Sharp
{
    [External]
    public partial class sap
    {
        [External]
        public static partial class ui
        {
            [External]
            public static partial class @base
            {
                [External]
                public partial class ManagedObject
                {
                    /// <summary>
                    /// Get the model to be used for data bindings with the given model name. If the object does not have a model set on itself, it will use the first model defined in its parent hierarchy.
                    /// 
                    /// The name can be omitted to reference the default model or it must be a non-empty string.
                    /// 
                    /// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
                    /// </summary>
                    /// <param name="sName">name of the model to be retrieved</param>
                    /// <returns>oModel</returns>
                    [Name("getModel")]
                    public virtual extern sap.ui.model.Model<TModel> getModelFor<TModel>(object sName);

                    /// <summary>
                    /// Get the model to be used for data bindings with the given model name. If the object does not have a model set on itself, it will use the first model defined in its parent hierarchy.
                    /// 
                    /// The name can be omitted to reference the default model or it must be a non-empty string.
                    /// 
                    /// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
                    /// </summary>
                    /// <returns>oModel</returns>
                    [Name("getModel")]
                    public virtual extern sap.ui.model.Model<TModel> getModelFor<TModel>();
                }
            }

            [External]
            public static partial class model
            {
                [External]
                public partial class Model<TModel> : sap.ui.model.Model
                {
                }

                [External]
                public partial class Context
                {
                    [Template("{this}")]
                    public virtual extern sap.ui.model.Context<TModel> For<TModel>();
                }

                [External]
                public partial class Context<TModel> : sap.ui.model.Context
                {
                    public extern Context(Model oModel, string sPath);
                }
            }
        }
    }
}
