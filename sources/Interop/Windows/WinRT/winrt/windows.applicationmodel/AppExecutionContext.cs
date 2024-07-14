// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppExecutionContext.xml' path='doc/member[@name="AppExecutionContext"]/*' />
public enum AppExecutionContext
{
    /// <include file='AppExecutionContext.xml' path='doc/member[@name="AppExecutionContext.AppExecutionContext_Unknown"]/*' />
    AppExecutionContext_Unknown = 0,

    /// <include file='AppExecutionContext.xml' path='doc/member[@name="AppExecutionContext.AppExecutionContext_Host"]/*' />
    AppExecutionContext_Host = 1,

    /// <include file='AppExecutionContext.xml' path='doc/member[@name="AppExecutionContext.AppExecutionContext_Guest"]/*' />
    AppExecutionContext_Guest = 2,
}
