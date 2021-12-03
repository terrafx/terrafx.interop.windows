// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT;

/// <include file='MLOperatorSchemaEdgeDescription.xml' path='doc/member[@name="MLOperatorSchemaEdgeDescription"]/*' />
public unsafe partial struct MLOperatorSchemaEdgeDescription
{
    /// <include file='MLOperatorSchemaEdgeDescription.xml' path='doc/member[@name="MLOperatorSchemaEdgeDescription.options"]/*' />
    public MLOperatorParameterOptions options;

    /// <include file='MLOperatorSchemaEdgeDescription.xml' path='doc/member[@name="MLOperatorSchemaEdgeDescription.typeFormat"]/*' />
    public MLOperatorSchemaEdgeTypeFormat typeFormat;

    /// <include file='MLOperatorSchemaEdgeDescription.xml' path='doc/member[@name="MLOperatorSchemaEdgeDescription.Anonymous"]/*' />
    [NativeTypeName("MLOperatorSchemaEdgeDescription::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/MLOperatorAuthor.h:424:5)")]
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.typeLabel"]/*' />
    public ref sbyte* typeLabel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.typeLabel;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.edgeDescription"]/*' />
    public ref MLOperatorEdgeDescription edgeDescription
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.edgeDescription, 1));
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

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.typeLabel"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const char *")]
        public sbyte* typeLabel;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.edgeDescription"]/*' />
        [FieldOffset(0)]
        public MLOperatorEdgeDescription edgeDescription;
    }
}
