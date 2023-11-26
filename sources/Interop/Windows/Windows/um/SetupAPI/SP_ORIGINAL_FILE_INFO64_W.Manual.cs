// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_ORIGINAL_FILE_INFO64_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("WCHAR[260]")]
    public _OriginalInfName_e__FixedBuffer OriginalInfName;

    [NativeTypeName("WCHAR[260]")]
    public _OriginalCatalogName_e__FixedBuffer OriginalCatalogName;

    [InlineArray(260)]
    public partial struct _OriginalInfName_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(260)]
    public partial struct _OriginalCatalogName_e__FixedBuffer
    {
        public char e0;
    }
}
