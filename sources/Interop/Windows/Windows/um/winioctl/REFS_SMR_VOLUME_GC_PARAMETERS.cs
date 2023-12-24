// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='REFS_SMR_VOLUME_GC_PARAMETERS.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_PARAMETERS"]/*' />
public partial struct REFS_SMR_VOLUME_GC_PARAMETERS
{
    /// <include file='REFS_SMR_VOLUME_GC_PARAMETERS.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_PARAMETERS.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='REFS_SMR_VOLUME_GC_PARAMETERS.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_PARAMETERS.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='REFS_SMR_VOLUME_GC_PARAMETERS.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_PARAMETERS.Action"]/*' />
    public REFS_SMR_VOLUME_GC_ACTION Action;

    /// <include file='REFS_SMR_VOLUME_GC_PARAMETERS.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_PARAMETERS.Method"]/*' />
    public REFS_SMR_VOLUME_GC_METHOD Method;

    /// <include file='REFS_SMR_VOLUME_GC_PARAMETERS.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_PARAMETERS.IoGranularity"]/*' />
    [NativeTypeName("DWORD")]
    public uint IoGranularity;

    /// <include file='REFS_SMR_VOLUME_GC_PARAMETERS.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_PARAMETERS.CompressionFormat"]/*' />
    [NativeTypeName("DWORD")]
    public uint CompressionFormat;

    /// <include file='REFS_SMR_VOLUME_GC_PARAMETERS.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_PARAMETERS.Unused"]/*' />
    [NativeTypeName("DWORDLONG[8]")]
    public _Unused_e__FixedBuffer Unused;

    /// <include file='_Unused_e__FixedBuffer.xml' path='doc/member[@name="_Unused_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Unused_e__FixedBuffer
    {
        public ulong e0;
    }
}
