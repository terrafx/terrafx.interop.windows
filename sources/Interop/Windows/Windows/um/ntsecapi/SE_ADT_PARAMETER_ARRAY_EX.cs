// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX"]/*' />
public partial struct SE_ADT_PARAMETER_ARRAY_EX
{
    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.CategoryId"]/*' />
    [NativeTypeName("ULONG")]
    public uint CategoryId;

    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.AuditId"]/*' />
    [NativeTypeName("ULONG")]
    public uint AuditId;

    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.Version"]/*' />
    [NativeTypeName("ULONG")]
    public uint Version;

    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.ParameterCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint ParameterCount;

    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.FlatSubCategoryId"]/*' />
    public ushort FlatSubCategoryId;

    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.Type"]/*' />
    public ushort Type;

    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='SE_ADT_PARAMETER_ARRAY_EX.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_EX.Parameters"]/*' />
    [NativeTypeName("SE_ADT_PARAMETER_ARRAY_ENTRY[32]")]
    public _Parameters_e__FixedBuffer Parameters;

    /// <include file='_Parameters_e__FixedBuffer.xml' path='doc/member[@name="_Parameters_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _Parameters_e__FixedBuffer
    {
        public SE_ADT_PARAMETER_ARRAY_ENTRY e0;
    }
}
