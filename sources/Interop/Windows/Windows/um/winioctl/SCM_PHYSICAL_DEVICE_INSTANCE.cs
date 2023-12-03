// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_PHYSICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_PHYSICAL_DEVICE_INSTANCE"]/*' />
public partial struct SCM_PHYSICAL_DEVICE_INSTANCE
{
    /// <include file='SCM_PHYSICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_PHYSICAL_DEVICE_INSTANCE.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PHYSICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_PHYSICAL_DEVICE_INSTANCE.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PHYSICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_PHYSICAL_DEVICE_INSTANCE.NfitHandle"]/*' />
    [NativeTypeName("DWORD")]
    public uint NfitHandle;

    /// <include file='SCM_PHYSICAL_DEVICE_INSTANCE.xml' path='doc/member[@name="SCM_PHYSICAL_DEVICE_INSTANCE.SymbolicLink"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _SymbolicLink_e__FixedBuffer SymbolicLink;

    /// <include file='_SymbolicLink_e__FixedBuffer.xml' path='doc/member[@name="_SymbolicLink_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _SymbolicLink_e__FixedBuffer
    {
        public char e0;
    }
}
