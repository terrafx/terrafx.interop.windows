// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WCM_PROFILE_INFO.xml' path='doc/member[@name="WCM_PROFILE_INFO"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct WCM_PROFILE_INFO
{
    /// <include file='WCM_PROFILE_INFO.xml' path='doc/member[@name="WCM_PROFILE_INFO.strProfileName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _strProfileName_e__FixedBuffer strProfileName;

    /// <include file='WCM_PROFILE_INFO.xml' path='doc/member[@name="WCM_PROFILE_INFO.AdapterGUID"]/*' />
    public Guid AdapterGUID;

    /// <include file='WCM_PROFILE_INFO.xml' path='doc/member[@name="WCM_PROFILE_INFO.Media"]/*' />
    public WCM_MEDIA_TYPE Media;

    /// <include file='_strProfileName_e__FixedBuffer.xml' path='doc/member[@name="_strProfileName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _strProfileName_e__FixedBuffer
    {
        public char e0;
    }
}
