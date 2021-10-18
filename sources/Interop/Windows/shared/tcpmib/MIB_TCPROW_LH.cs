// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MIB_TCPROW_LH
    {
        [NativeTypeName("_MIB_TCPROW_LH::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/tcpmib.h:69:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        public ref uint dwState
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwState, 1));
            }
        }

        public ref MIB_TCP_STATE State
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.State, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwState;

            [FieldOffset(0)]
            public MIB_TCP_STATE State;
        }
    }
}
