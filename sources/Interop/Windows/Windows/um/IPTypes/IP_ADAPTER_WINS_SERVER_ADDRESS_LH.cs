// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IP_ADAPTER_WINS_SERVER_ADDRESS_LH.xml' path='doc/member[@name="IP_ADAPTER_WINS_SERVER_ADDRESS_LH"]/*' />
public unsafe partial struct IP_ADAPTER_WINS_SERVER_ADDRESS_LH
{
    /// <include file='IP_ADAPTER_WINS_SERVER_ADDRESS_LH.xml' path='doc/member[@name="IP_ADAPTER_WINS_SERVER_ADDRESS_LH.Anonymous"]/*' />
    [NativeTypeName("_IP_ADAPTER_WINS_SERVER_ADDRESS_LH::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:218:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='IP_ADAPTER_WINS_SERVER_ADDRESS_LH.xml' path='doc/member[@name="IP_ADAPTER_WINS_SERVER_ADDRESS_LH.Next"]/*' />
    [NativeTypeName("struct _IP_ADAPTER_WINS_SERVER_ADDRESS_LH *")]
    public IP_ADAPTER_WINS_SERVER_ADDRESS_LH* Next;

    /// <include file='IP_ADAPTER_WINS_SERVER_ADDRESS_LH.xml' path='doc/member[@name="IP_ADAPTER_WINS_SERVER_ADDRESS_LH.Address"]/*' />
    public SOCKET_ADDRESS Address;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Alignment"]/*' />
    public ref ulong Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Alignment, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Length"]/*' />
    public ref uint Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Length, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
    public ref uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Reserved, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Alignment"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Alignment;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_IP_ADAPTER_WINS_SERVER_ADDRESS_LH::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:220:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Length"]/*' />
            [NativeTypeName("ULONG")]
            public uint Length;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("DWORD")]
            public uint Reserved;
        }
    }
}
