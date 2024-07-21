// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactAnnotationStoreAccessType.xml' path='doc/member[@name="ContactAnnotationStoreAccessType"]/*' />
public enum ContactAnnotationStoreAccessType
{
    /// <include file='ContactAnnotationStoreAccessType.xml' path='doc/member[@name="ContactAnnotationStoreAccessType.ContactAnnotationStoreAccessType_AppAnnotationsReadWrite"]/*' />
    ContactAnnotationStoreAccessType_AppAnnotationsReadWrite = 0,

    /// <include file='ContactAnnotationStoreAccessType.xml' path='doc/member[@name="ContactAnnotationStoreAccessType.ContactAnnotationStoreAccessType_AllAnnotationsReadWrite"]/*' />
    ContactAnnotationStoreAccessType_AllAnnotationsReadWrite = 1,
}
