// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [Unmanaged]
    public unsafe struct DXGI_ADAPTER_DESC
    {
        #region Fields
        [NativeTypeName("WCHAR[128]")]
        public fixed char Description[128];

        [NativeTypeName("UINT")]
        public uint VendorId;

        [NativeTypeName("UINT")]
        public uint DeviceId;

        [NativeTypeName("UINT")]
        public uint SubSysId;

        [NativeTypeName("UINT")]
        public uint Revision;

        [NativeTypeName("SIZE_T")]
        public UIntPtr DedicatedVideoMemory;

        [NativeTypeName("SIZE_T")]
        public UIntPtr DedicatedSystemMemory;

        [NativeTypeName("SIZE_T")]
        public UIntPtr SharedSystemMemory;

        public LUID AdapterLuid;
        #endregion
    }
}
