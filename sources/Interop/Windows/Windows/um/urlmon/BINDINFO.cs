// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct BINDINFO
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("LPWSTR")]
        public ushort* szExtraInfo;

        public STGMEDIUM stgmedData;

        [NativeTypeName("DWORD")]
        public uint grfBindInfoF;

        [NativeTypeName("DWORD")]
        public uint dwBindVerb;

        [NativeTypeName("LPWSTR")]
        public ushort* szCustomVerb;

        [NativeTypeName("DWORD")]
        public uint cbstgmedData;

        [NativeTypeName("DWORD")]
        public uint dwOptions;

        [NativeTypeName("DWORD")]
        public uint dwOptionsFlags;

        [NativeTypeName("DWORD")]
        public uint dwCodePage;

        public SECURITY_ATTRIBUTES securityAttributes;

        [NativeTypeName("IID")]
        public Guid iid;

        public IUnknown* pUnk;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }
}
