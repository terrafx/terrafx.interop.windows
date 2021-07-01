// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct WTD_GENERIC_CHAIN_POLICY_CREATE_INFO
    {
        [NativeTypeName("_WTD_GENERIC_CHAIN_POLICY_CREATE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/SoftPub.h:160:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("HCERTCHAINENGINE")]
        public IntPtr hChainEngine;

        [NativeTypeName("PCERT_CHAIN_PARA")]
        public CERT_CHAIN_PARA* pChainPara;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public void* pvReserved;

        public ref uint cbStruct
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbStruct, 1));
            }
        }

        public ref uint cbSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cbSize, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cbStruct;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cbSize;
        }
    }
}
