﻿using System.Security.AccessControl;
using Microsoft.Win32;
using SystemInterface.Security.AccessControl;

namespace SystemWrapper.Security.AccessControl
{
    /// <summary>
    /// RegistrySecurityWrap is a wrapper for RegistrySecurity
    /// that implements IRegistrySecurity. Using this instead
    /// of using RegistrySecurity directly
    /// </summary>
    public class RegistrySecurityWrap : IRegistrySecurity
    {
        /// <summary>
        /// The Constructor
        /// </summary>
        /// <param name="registrySecurity"></param>
        public RegistrySecurityWrap(RegistrySecurity registrySecurity)
        {
            RegistrySecurityInstance = registrySecurity;
        }

        #region Implementation of IRegistrySecurity

        /// <inheritdoc />
        public RegistrySecurity RegistrySecurityInstance { get; private set; }

        #endregion
    }
}
