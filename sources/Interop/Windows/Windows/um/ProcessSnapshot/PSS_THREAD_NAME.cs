// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PSS_THREAD_NAME.xml' path='doc/member[@name="PSS_THREAD_NAME"]/*' />
public unsafe partial struct PSS_THREAD_NAME
{
    /// <include file='PSS_THREAD_NAME.xml' path='doc/member[@name="PSS_THREAD_NAME.ThreadNameSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort ThreadNameSize;

    /// <include file='PSS_THREAD_NAME.xml' path='doc/member[@name="PSS_THREAD_NAME.ThreadName"]/*' />
    [NativeTypeName("const wchar_t *")]
    public char* ThreadName;
}
