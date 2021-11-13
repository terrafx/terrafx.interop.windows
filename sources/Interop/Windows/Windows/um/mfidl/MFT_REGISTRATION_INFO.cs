// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct MFT_REGISTRATION_INFO
    {
        [NativeTypeName("CLSID")]
        public Guid clsid;

        public Guid guidCategory;

        [NativeTypeName("UINT32")]
        public uint uiFlags;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszName;

        [NativeTypeName("DWORD")]
        public uint cInTypes;

        public MFT_REGISTER_TYPE_INFO* pInTypes;

        [NativeTypeName("DWORD")]
        public uint cOutTypes;

        public MFT_REGISTER_TYPE_INFO* pOutTypes;
    }
}
