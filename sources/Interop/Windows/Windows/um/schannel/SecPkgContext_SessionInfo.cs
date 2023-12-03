// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SecPkgContext_SessionInfo.xml' path='doc/member[@name="SecPkgContext_SessionInfo"]/*' />
public partial struct SecPkgContext_SessionInfo
{
    /// <include file='SecPkgContext_SessionInfo.xml' path='doc/member[@name="SecPkgContext_SessionInfo.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='SecPkgContext_SessionInfo.xml' path='doc/member[@name="SecPkgContext_SessionInfo.cbSessionId"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSessionId;

    /// <include file='SecPkgContext_SessionInfo.xml' path='doc/member[@name="SecPkgContext_SessionInfo.rgbSessionId"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _rgbSessionId_e__FixedBuffer rgbSessionId;

    /// <include file='_rgbSessionId_e__FixedBuffer.xml' path='doc/member[@name="_rgbSessionId_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _rgbSessionId_e__FixedBuffer
    {
        public byte e0;
    }
}
