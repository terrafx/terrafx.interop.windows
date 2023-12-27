// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='JsonValueType.xml' path='doc/member[@name="JsonValueType"]/*' />
public enum JsonValueType
{
    /// <include file='JsonValueType.xml' path='doc/member[@name="JsonValueType.JsonValueType_Null"]/*' />
    JsonValueType_Null = 0,

    /// <include file='JsonValueType.xml' path='doc/member[@name="JsonValueType.JsonValueType_Boolean"]/*' />
    JsonValueType_Boolean = 1,

    /// <include file='JsonValueType.xml' path='doc/member[@name="JsonValueType.JsonValueType_Number"]/*' />
    JsonValueType_Number = 2,

    /// <include file='JsonValueType.xml' path='doc/member[@name="JsonValueType.JsonValueType_String"]/*' />
    JsonValueType_String = 3,

    /// <include file='JsonValueType.xml' path='doc/member[@name="JsonValueType.JsonValueType_Array"]/*' />
    JsonValueType_Array = 4,

    /// <include file='JsonValueType.xml' path='doc/member[@name="JsonValueType.JsonValueType_Object"]/*' />
    JsonValueType_Object = 5,
}
