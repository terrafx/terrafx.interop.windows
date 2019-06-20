// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Diagnostics;

namespace TerraFX.Utilities
{
    /// <summary>Defines a struct which is contracted to meet the C# unmanaged constraint.</summary>
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    [Conditional("DEBUG")]
    internal sealed class UnmanagedAttribute : Attribute
    {
    }
}
