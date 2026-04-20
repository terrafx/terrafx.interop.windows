// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='InputQPSettings.xml' path='doc/member[@name="InputQPSettings"]/*' />
public partial struct InputQPSettings
{
    /// <include file='InputQPSettings.xml' path='doc/member[@name="InputQPSettings.minBlockSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint minBlockSize;

    /// <include file='InputQPSettings.xml' path='doc/member[@name="InputQPSettings.maxBlockSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint maxBlockSize;

    /// <include file='InputQPSettings.xml' path='doc/member[@name="InputQPSettings.stepsBlockSize"]/*' />
    [NativeTypeName("UINT32")]
    public uint stepsBlockSize;

    /// <include file='InputQPSettings.xml' path='doc/member[@name="InputQPSettings.dataType"]/*' />
    public eAVEncVideoQPMapElementDataType dataType;

    /// <include file='InputQPSettings.xml' path='doc/member[@name="InputQPSettings.minValue"]/*' />
    [NativeTypeName("INT16")]
    public short minValue;

    /// <include file='InputQPSettings.xml' path='doc/member[@name="InputQPSettings.maxValue"]/*' />
    [NativeTypeName("INT16")]
    public short maxValue;

    /// <include file='InputQPSettings.xml' path='doc/member[@name="InputQPSettings.steps"]/*' />
    [NativeTypeName("UINT16")]
    public ushort steps;
}
