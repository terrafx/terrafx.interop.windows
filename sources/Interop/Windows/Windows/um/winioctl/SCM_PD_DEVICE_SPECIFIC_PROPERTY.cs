// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PD_DEVICE_SPECIFIC_PROPERTY.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_PROPERTY"]/*' />
public partial struct SCM_PD_DEVICE_SPECIFIC_PROPERTY
{
    /// <include file='SCM_PD_DEVICE_SPECIFIC_PROPERTY.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_PROPERTY.Name"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='SCM_PD_DEVICE_SPECIFIC_PROPERTY.xml' path='doc/member[@name="SCM_PD_DEVICE_SPECIFIC_PROPERTY.Value"]/*' />
    [NativeTypeName("LONGLONG")]
    public long Value;

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _Name_e__FixedBuffer
    {
        public char e0;
    }
}
