// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT;

/// <include file='MLOperatorEdgeDescription.xml' path='doc/member[@name="MLOperatorEdgeDescription"]/*' />
public partial struct MLOperatorEdgeDescription
{
    /// <include file='MLOperatorEdgeDescription.xml' path='doc/member[@name="MLOperatorEdgeDescription.edgeType"]/*' />
    public MLOperatorEdgeType edgeType;

    /// <include file='MLOperatorEdgeDescription.xml' path='doc/member[@name="MLOperatorEdgeDescription.Anonymous"]/*' />
    [NativeTypeName("MLOperatorEdgeDescription::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/MLOperatorAuthor.h:117:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.reserved"]/*' />
    public ref ulong reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.reserved, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.tensorDataType"]/*' />
    public ref MLOperatorTensorDataType tensorDataType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.tensorDataType, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("uint64_t")]
        public ulong reserved;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.tensorDataType"]/*' />
        [FieldOffset(0)]
        public MLOperatorTensorDataType tensorDataType;
    }
}
