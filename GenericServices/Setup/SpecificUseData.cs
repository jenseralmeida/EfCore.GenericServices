﻿// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT licence. See License.txt in the project root for license information.

using System;
using GenericServices.Configuration;
using GenericServices.PublicButHidden;
using GenericServices.Setup.Internal;

namespace GenericServices.Setup
{
    /// <summary>
    /// This holds specific config and mapping data - useful in unit testing and serverless applications
    /// </summary>
    public class SpecificUseData
    { 
        internal MappingProfile ReadProfile { get; }
        internal MappingProfile SaveProfile { get; }

        /// <summary>
        /// This holds the global configuration and the AutoMapper data
        /// </summary>
        public IWrappedConfigAndMapper ConfigAndMapper => SetupDtosAndMappings.CreateConfigAndMapper(PublicConfig, ReadProfile, SaveProfile);

        /// <summary>
        /// This is the global config
        /// </summary>
        public IGenericServicesConfig PublicConfig { get; }
    
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="publicConfig"></param>
        public SpecificUseData(IGenericServicesConfig publicConfig)
        {
            PublicConfig = publicConfig ?? new GenericServicesConfig();
            ReadProfile = new MappingProfile(false);
            SaveProfile = new MappingProfile(true);
        }
    }
}