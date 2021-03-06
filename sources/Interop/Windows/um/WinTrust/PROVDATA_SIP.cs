// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PROVDATA_SIP
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("GUID")]
        public Guid gSubject;

        [NativeTypeName("struct SIP_DISPATCH_INFO_ *")]
        public SIP_DISPATCH_INFO* pSip;

        [NativeTypeName("struct SIP_DISPATCH_INFO_ *")]
        public SIP_DISPATCH_INFO* pCATSip;

        [NativeTypeName("struct SIP_SUBJECTINFO_ *")]
        public SIP_SUBJECTINFO* psSipSubjectInfo;

        [NativeTypeName("struct SIP_SUBJECTINFO_ *")]
        public SIP_SUBJECTINFO* psSipCATSubjectInfo;

        [NativeTypeName("struct SIP_INDIRECT_DATA_ *")]
        public SIP_INDIRECT_DATA* psIndirectData;
    }
}
