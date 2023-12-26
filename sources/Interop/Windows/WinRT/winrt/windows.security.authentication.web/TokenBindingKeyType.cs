// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TokenBindingKeyType.xml' path='doc/member[@name="TokenBindingKeyType"]/*' />
public enum TokenBindingKeyType
{
    /// <include file='TokenBindingKeyType.xml' path='doc/member[@name="TokenBindingKeyType.TokenBindingKeyType_Rsa2048"]/*' />
    TokenBindingKeyType_Rsa2048 = 0,

    /// <include file='TokenBindingKeyType.xml' path='doc/member[@name="TokenBindingKeyType.TokenBindingKeyType_EcdsaP256"]/*' />
    TokenBindingKeyType_EcdsaP256 = 1,

    /// <include file='TokenBindingKeyType.xml' path='doc/member[@name="TokenBindingKeyType.TokenBindingKeyType_AnyExisting"]/*' />
    TokenBindingKeyType_AnyExisting = 2,
}
