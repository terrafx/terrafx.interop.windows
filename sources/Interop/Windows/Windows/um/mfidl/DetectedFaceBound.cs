// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DetectedFaceBound.xml' path='doc/member[@name="DetectedFaceBound"]/*' />
public partial struct DetectedFaceBound
{
    /// <include file='DetectedFaceBound.xml' path='doc/member[@name="DetectedFaceBound.sizeInBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint sizeInBytes;

    /// <include file='DetectedFaceBound.xml' path='doc/member[@name="DetectedFaceBound.normalizedXPosition"]/*' />
    public float normalizedXPosition;

    /// <include file='DetectedFaceBound.xml' path='doc/member[@name="DetectedFaceBound.normalizedYPosition"]/*' />
    public float normalizedYPosition;

    /// <include file='DetectedFaceBound.xml' path='doc/member[@name="DetectedFaceBound.normalizedWidth"]/*' />
    public float normalizedWidth;

    /// <include file='DetectedFaceBound.xml' path='doc/member[@name="DetectedFaceBound.normalizedHeight"]/*' />
    public float normalizedHeight;

    /// <include file='DetectedFaceBound.xml' path='doc/member[@name="DetectedFaceBound.confidenceValue"]/*' />
    [NativeTypeName("LONG")]
    public int confidenceValue;

    /// <include file='DetectedFaceBound.xml' path='doc/member[@name="DetectedFaceBound.flags"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong flags;
}
