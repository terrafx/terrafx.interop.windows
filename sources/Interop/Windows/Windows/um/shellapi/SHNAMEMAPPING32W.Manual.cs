// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHNAMEMAPPING32W
{
    [NativeTypeName("LPWSTR")]
    public ushort* pszOldPath;

    [NativeTypeName("LPWSTR")]
    public ushort* pszNewPath;

    public int cchOldPath;

    public int cchNewPath;
}
