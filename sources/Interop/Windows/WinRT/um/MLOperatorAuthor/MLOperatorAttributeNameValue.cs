// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT;

/// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue"]/*' />
public unsafe partial struct MLOperatorAttributeNameValue
{
    /// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue.name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* name;

    /// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue.type"]/*' />
    public MLOperatorAttributeType type;

    /// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue.valueCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint valueCount;

    /// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue.Anonymous"]/*' />
    [NativeTypeName("MLOperatorAttributeNameValue::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/MLOperatorAuthor.h:600:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.reserved"]/*' />
    public ref void* reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.reserved;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ints"]/*' />
    public ref long* ints
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.ints;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strings"]/*' />
    public ref sbyte** strings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.strings;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.floats"]/*' />
    public ref float* floats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.floats;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* reserved;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ints"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const int64_t *")]
        public long* ints;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strings"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const char *const *")]
        public sbyte** strings;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.floats"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const float *")]
        public float* floats;
    }
}
