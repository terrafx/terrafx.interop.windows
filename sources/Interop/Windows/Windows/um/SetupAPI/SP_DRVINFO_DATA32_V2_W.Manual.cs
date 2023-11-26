// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_DRVINFO_DATA32_V2_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint DriverType;

    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;

    [NativeTypeName("WCHAR[256]")]
    public _Description_e__FixedBuffer Description;

    [NativeTypeName("WCHAR[256]")]
    public _MfgName_e__FixedBuffer MfgName;

    [NativeTypeName("WCHAR[256]")]
    public _ProviderName_e__FixedBuffer ProviderName;

    public FILETIME DriverDate;

    [NativeTypeName("DWORDLONG")]
    public ulong DriverVersion;

    [InlineArray(256)]
    public partial struct _Description_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(256)]
    public partial struct _MfgName_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(256)]
    public partial struct _ProviderName_e__FixedBuffer
    {
        public char e0;
    }
}
