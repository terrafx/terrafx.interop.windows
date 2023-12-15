// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_INF_SIGNER_INFO32_V2_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("WCHAR[260]")]
    public _CatalogFile_e__FixedBuffer CatalogFile;

    [NativeTypeName("WCHAR[260]")]
    public _DigitalSigner_e__FixedBuffer DigitalSigner;

    [NativeTypeName("WCHAR[260]")]
    public _DigitalSignerVersion_e__FixedBuffer DigitalSignerVersion;

    [NativeTypeName("DWORD")]
    public uint SignerScore;

    [InlineArray(260)]
    public partial struct _CatalogFile_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(260)]
    public partial struct _DigitalSigner_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(260)]
    public partial struct _DigitalSignerVersion_e__FixedBuffer
    {
        public char e0;
    }
}
