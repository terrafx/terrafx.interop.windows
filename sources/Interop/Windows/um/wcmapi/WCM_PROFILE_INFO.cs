// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WCM_PROFILE_INFO
    {
        [NativeTypeName("WCHAR [256]")]
        public fixed ushort strProfileName[256];

        [NativeTypeName("GUID")]
        public Guid AdapterGUID;

        public WCM_MEDIA_TYPE Media;
    }
}
