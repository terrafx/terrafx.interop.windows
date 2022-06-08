// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='GenericCredentialProvider.xml' path='doc/member[@name="GenericCredentialProvider"]/*' />
[Guid("25CBB996-92ED-457E-B28C-4774084BD562")]
public partial struct GenericCredentialProvider : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_GenericCredentialProvider;
}
