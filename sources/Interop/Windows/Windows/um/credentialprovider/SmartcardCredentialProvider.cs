// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='SmartcardCredentialProvider.xml' path='doc/member[@name="SmartcardCredentialProvider"]/*' />
[Guid("8FD7E19C-3BF7-489B-A72C-846AB3678C96")]
public partial struct SmartcardCredentialProvider : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_SmartcardCredentialProvider;
}
