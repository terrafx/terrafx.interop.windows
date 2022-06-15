// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='OnexCredentialProvider.xml' path='doc/member[@name="OnexCredentialProvider"]/*' />
[Guid("07AA0886-CC8D-4E19-A410-1C75AF686E62")]
public partial struct OnexCredentialProvider : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_OnexCredentialProvider;
}
