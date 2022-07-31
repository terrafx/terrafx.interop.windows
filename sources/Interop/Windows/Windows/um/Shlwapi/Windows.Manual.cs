// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wnsprintfW"]/*' />
    [DllImport("shlwapi", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wnsprintfW", ExactSpelling = true)]
    public static extern int wnsprintf([NativeTypeName("PWSTR")] ushort* pszDest, int cchDest, [NativeTypeName("PCWSTR")] ushort* pszFmt, __arglist);
}
