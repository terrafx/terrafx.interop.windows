// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_QUERY_DESC1
    {
        public D3D11_QUERY Query;

        [NativeTypeName("UINT")]
        public uint MiscFlags;

        public D3D11_CONTEXT_TYPE ContextType;
    }
}
