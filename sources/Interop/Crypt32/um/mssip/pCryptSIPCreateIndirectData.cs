// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int pCryptSIPCreateIndirectData([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD *")] uint* pcbIndirectData, [NativeTypeName("SIP_INDIRECT_DATA *")] SIP_INDIRECT_DATA* pIndirectData);
}
