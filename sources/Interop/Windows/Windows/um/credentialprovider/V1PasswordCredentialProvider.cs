// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='V1PasswordCredentialProvider.xml' path='doc/member[@name="V1PasswordCredentialProvider"]/*' />
[Guid("6F45DC1E-5384-457A-BC13-2CD81B0D28ED")]
public partial struct V1PasswordCredentialProvider : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_V1PasswordCredentialProvider;
}
