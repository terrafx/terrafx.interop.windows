// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='JsonErrorStatus.xml' path='doc/member[@name="JsonErrorStatus"]/*' />
public enum JsonErrorStatus
{
    /// <include file='JsonErrorStatus.xml' path='doc/member[@name="JsonErrorStatus.JsonErrorStatus_Unknown"]/*' />
    JsonErrorStatus_Unknown = 0,

    /// <include file='JsonErrorStatus.xml' path='doc/member[@name="JsonErrorStatus.JsonErrorStatus_InvalidJsonString"]/*' />
    JsonErrorStatus_InvalidJsonString = 1,

    /// <include file='JsonErrorStatus.xml' path='doc/member[@name="JsonErrorStatus.JsonErrorStatus_InvalidJsonNumber"]/*' />
    JsonErrorStatus_InvalidJsonNumber = 2,

    /// <include file='JsonErrorStatus.xml' path='doc/member[@name="JsonErrorStatus.JsonErrorStatus_JsonValueNotFound"]/*' />
    JsonErrorStatus_JsonValueNotFound = 3,

    /// <include file='JsonErrorStatus.xml' path='doc/member[@name="JsonErrorStatus.JsonErrorStatus_ImplementationLimit"]/*' />
    JsonErrorStatus_ImplementationLimit = 4,
}
