// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D3D11_AUTHENTICATED_CONFIGURE_INPUT
    {
        public D3D11_OMAC omac;

        [NativeTypeName("GUID")]
        public Guid ConfigureType;

        [NativeTypeName("HANDLE")]
        public IntPtr hChannel;

        [NativeTypeName("UINT")]
        public uint SequenceNumber;
    }
}
