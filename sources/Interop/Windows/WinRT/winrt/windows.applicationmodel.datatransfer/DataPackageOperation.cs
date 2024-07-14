// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DataPackageOperation.xml' path='doc/member[@name="DataPackageOperation"]/*' />
[NativeTypeName("unsigned int")]
public enum DataPackageOperation : uint
{
    /// <include file='DataPackageOperation.xml' path='doc/member[@name="DataPackageOperation.DataPackageOperation_None"]/*' />
    DataPackageOperation_None = 0,

    /// <include file='DataPackageOperation.xml' path='doc/member[@name="DataPackageOperation.DataPackageOperation_Copy"]/*' />
    DataPackageOperation_Copy = 0x1,

    /// <include file='DataPackageOperation.xml' path='doc/member[@name="DataPackageOperation.DataPackageOperation_Move"]/*' />
    DataPackageOperation_Move = 0x2,

    /// <include file='DataPackageOperation.xml' path='doc/member[@name="DataPackageOperation.DataPackageOperation_Link"]/*' />
    DataPackageOperation_Link = 0x4,
}
