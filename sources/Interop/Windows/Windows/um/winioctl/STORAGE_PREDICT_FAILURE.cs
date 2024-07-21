// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_PREDICT_FAILURE.xml' path='doc/member[@name="STORAGE_PREDICT_FAILURE"]/*' />
public partial struct STORAGE_PREDICT_FAILURE
{
    /// <include file='STORAGE_PREDICT_FAILURE.xml' path='doc/member[@name="STORAGE_PREDICT_FAILURE.PredictFailure"]/*' />
    [NativeTypeName("DWORD")]
    public uint PredictFailure;

    /// <include file='STORAGE_PREDICT_FAILURE.xml' path='doc/member[@name="STORAGE_PREDICT_FAILURE.VendorSpecific"]/*' />
    [NativeTypeName("BYTE[512]")]
    public _VendorSpecific_e__FixedBuffer VendorSpecific;

    /// <include file='_VendorSpecific_e__FixedBuffer.xml' path='doc/member[@name="_VendorSpecific_e__FixedBuffer"]/*' />
    [InlineArray(512)]
    public partial struct _VendorSpecific_e__FixedBuffer
    {
        public byte e0;
    }
}
