// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct MIB_IPSTATS_LH
    {
        [NativeTypeName("_MIB_IPSTATS_LH::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ipmib.h:202:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint dwDefaultTTL;

        [NativeTypeName("DWORD")]
        public uint dwInReceives;

        [NativeTypeName("DWORD")]
        public uint dwInHdrErrors;

        [NativeTypeName("DWORD")]
        public uint dwInAddrErrors;

        [NativeTypeName("DWORD")]
        public uint dwForwDatagrams;

        [NativeTypeName("DWORD")]
        public uint dwInUnknownProtos;

        [NativeTypeName("DWORD")]
        public uint dwInDiscards;

        [NativeTypeName("DWORD")]
        public uint dwInDelivers;

        [NativeTypeName("DWORD")]
        public uint dwOutRequests;

        [NativeTypeName("DWORD")]
        public uint dwRoutingDiscards;

        [NativeTypeName("DWORD")]
        public uint dwOutDiscards;

        [NativeTypeName("DWORD")]
        public uint dwOutNoRoutes;

        [NativeTypeName("DWORD")]
        public uint dwReasmTimeout;

        [NativeTypeName("DWORD")]
        public uint dwReasmReqds;

        [NativeTypeName("DWORD")]
        public uint dwReasmOks;

        [NativeTypeName("DWORD")]
        public uint dwReasmFails;

        [NativeTypeName("DWORD")]
        public uint dwFragOks;

        [NativeTypeName("DWORD")]
        public uint dwFragFails;

        [NativeTypeName("DWORD")]
        public uint dwFragCreates;

        [NativeTypeName("DWORD")]
        public uint dwNumIf;

        [NativeTypeName("DWORD")]
        public uint dwNumAddr;

        [NativeTypeName("DWORD")]
        public uint dwNumRoutes;

        public ref uint dwForwarding
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwForwarding, 1));
            }
        }

        public ref MIB_IPSTATS_FORWARDING Forwarding
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Forwarding, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwForwarding;

            [FieldOffset(0)]
            public MIB_IPSTATS_FORWARDING Forwarding;
        }
    }
}
