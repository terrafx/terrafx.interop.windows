// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/winstring.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        /// <summary>Raised whenever a native library is loaded by TerraFX.Interop.Windows. Handlers can be added to this event to customize how libraries are loaded, and they will be used first whenever a new native library is being resolved.</summary>
        public static event DllImportResolver? ResolveLibrary;

        /// <summary>Initializes the DLL resolver for the current assembly.</summary>
        /// <returns>Just <see langword="null"/>, this method is only used to skip the static constructor and keep this type as <see langword="beforefieldinit"/>.</returns>
        [ModuleInitializer]
        internal static void SetDllImportResolver()
        {
            NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), OnDllImport);
        }

        /// <summary>The default <see cref="DllImportResolver"/> for TerraFX.Interop.Windows.</summary>
        /// <inheritdoc cref="DllImportResolver"/>
        private static IntPtr OnDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (TryResolveLibrary(libraryName, assembly, searchPath, out IntPtr nativeLibrary))
            {
                return nativeLibrary;
            }

            return NativeLibrary.Load(libraryName, assembly, searchPath);
        }

        /// <summary>Tries to resolve a native library using the handlers for the <see cref="ResolveLibrary"/> event.</summary>
        /// <param name="libraryName">The native library to resolve.</param>
        /// <param name="assembly">The assembly requesting the resolution.</param>
        /// <param name="searchPath">The <see cref="DllImportSearchPath"/> value on the P/Invoke or assembly, or <see langword="null"/>.</param>
        /// <param name="nativeLibrary">The loaded library, if one was resolved.</param>
        /// <returns>Whether or not the requested library was successfully loaded.</returns>
        private static bool TryResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
        {
            var resolveLibrary = ResolveLibrary;

            if (resolveLibrary != null)
            {
                var resolvers = resolveLibrary.GetInvocationList();

                foreach (DllImportResolver resolver in resolvers)
                {
                    nativeLibrary = resolver(libraryName, assembly, searchPath);

                    if (nativeLibrary != IntPtr.Zero)
                    {
                        return true;
                    }
                }
            }

            nativeLibrary = IntPtr.Zero;
            return false;
        }
    }
}
