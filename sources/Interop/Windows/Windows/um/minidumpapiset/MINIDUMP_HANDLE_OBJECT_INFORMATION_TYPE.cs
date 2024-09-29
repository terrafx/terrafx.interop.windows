// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE"]/*' />
public enum MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE
{
    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniHandleObjectInformationNone"]/*' />
    MiniHandleObjectInformationNone,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniThreadInformation1"]/*' />
    MiniThreadInformation1,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniMutantInformation1"]/*' />
    MiniMutantInformation1,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniMutantInformation2"]/*' />
    MiniMutantInformation2,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniProcessInformation1"]/*' />
    MiniProcessInformation1,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniProcessInformation2"]/*' />
    MiniProcessInformation2,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniEventInformation1"]/*' />
    MiniEventInformation1,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniSectionInformation1"]/*' />
    MiniSectionInformation1,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniSemaphoreInformation1"]/*' />
    MiniSemaphoreInformation1,

    /// <include file='MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.xml' path='doc/member[@name="MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE.MiniHandleObjectInformationTypeMax"]/*' />
    MiniHandleObjectInformationTypeMax,
}
