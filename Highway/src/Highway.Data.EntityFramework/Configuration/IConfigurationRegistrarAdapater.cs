﻿using System.Data.Entity.ModelConfiguration;
using System.Reflection;

namespace Highway.Data
{
    /// <summary>
    /// Testable stub over the configuration registrar
    /// </summary>
    public interface IConfigurationRegistrarAdapater
    {
        /// <summary>
        /// Discovers all types that inherit from <see cref="T:System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration"/> or
        ///             <see cref="T:System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration"/> in the given assembly and adds an instance
        ///             of each discovered type to this registrar.
        /// 
        /// </summary>
        /// 
        /// <remarks>
        /// Note that only types that are abstract or generic type definitions are skipped. Every
        ///             type that is discovered and added must provide a parameterless constructor.
        /// 
        /// </remarks>
        /// <param name="assembly">The assembly containing model configurations to add.</param>
        /// <returns>
        /// The same ConfigurationRegistrar instance so that multiple calls can be chained.
        /// </returns>
        ConfigurationRegistrarAdapater AddFromAssembly(Assembly assembly);

        /// <summary>
        /// Adds an <see cref="T:System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration"/> to the <see cref="T:System.Data.Entity.DbModelBuilder"/>.
        ///             Only one <see cref="T:System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration"/> can be added for each type in a model.
        /// 
        /// </summary>
        /// <typeparam name="TEntityType">The entity type being configured. </typeparam><param name="entityTypeConfiguration">The entity type configuration to be added. </param>
        /// <returns>
        /// The same ConfigurationRegistrar instance so that multiple calls can be chained.
        /// </returns>
        new ConfigurationRegistrarAdapater Add<TEntityType>(EntityTypeConfiguration<TEntityType> entityTypeConfiguration) where TEntityType : class;

        /// <summary>
        /// Adds an <see cref="T:System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration"/> to the <see cref="T:System.Data.Entity.DbModelBuilder"/>.
        ///             Only one <see cref="T:System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration"/> can be added for each type in a model.
        /// 
        /// </summary>
        /// <typeparam name="TComplexType">The complex type being configured. </typeparam><param name="complexTypeConfiguration">The complex type configuration to be added </param>
        /// <returns>
        /// The same ConfigurationRegistrar instance so that multiple calls can be chained.
        /// </returns>
        new ConfigurationRegistrarAdapater Add<TComplexType>(ComplexTypeConfiguration<TComplexType> complexTypeConfiguration) where TComplexType : class;
    }
}