// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_ICE_TYPE.xml' path='doc/member[@name="STORAGE_ICE_TYPE"]/*' />
public enum STORAGE_ICE_TYPE
{
    /// <include file='STORAGE_ICE_TYPE.xml' path='doc/member[@name="STORAGE_ICE_TYPE.StorageIceTypeUnknown"]/*' />
    StorageIceTypeUnknown = 0,

    /// <include file='STORAGE_ICE_TYPE.xml' path='doc/member[@name="STORAGE_ICE_TYPE.StorageIceTypeUfs"]/*' />
    StorageIceTypeUfs,

    /// <include file='STORAGE_ICE_TYPE.xml' path='doc/member[@name="STORAGE_ICE_TYPE.StorageIceTypeNvme"]/*' />
    StorageIceTypeNvme,
}
