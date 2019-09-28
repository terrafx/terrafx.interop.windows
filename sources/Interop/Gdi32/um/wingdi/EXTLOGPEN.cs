// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct EXTLOGPEN
    {
        [NativeTypeName("DWORD")]
        public uint elpPenStyle;

        [NativeTypeName("DWORD")]
        public uint elpWidth;

        [NativeTypeName("UINT")]
        public uint elpBrushStyle;

        [NativeTypeName("COLORREF")]
        public uint elpColor;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr elpHatch;

        [NativeTypeName("DWORD")]
        public uint elpNumEntries;

        [NativeTypeName("DWORD [1]")]
        public fixed uint elpStyleEntry[1];
    }
}
