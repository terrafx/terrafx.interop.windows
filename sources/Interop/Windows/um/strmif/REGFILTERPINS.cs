// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct REGFILTERPINS
    {
        [NativeTypeName("LPWSTR")]
        public ushort* strName;

        public BOOL bRendered;

        public BOOL bOutput;

        public BOOL bZero;

        public BOOL bMany;

        [NativeTypeName("const CLSID *")]
        public Guid* clsConnectsToFilter;

        [NativeTypeName("const WCHAR *")]
        public ushort* strConnectsToPin;

        [NativeTypeName("UINT")]
        public uint nMediaTypes;

        [NativeTypeName("const REGPINTYPES *")]
        public REGPINTYPES* lpMediaType;
    }
}
