// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("crypt32", EntryPoint = "CryptSIPGetSignedDataMsg", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPGetSignedDataMsg([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD *")] uint* pdwEncodingType, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pcbSignedDataMsg, [NativeTypeName("BYTE *")] byte* pbSignedDataMsg);

        [DllImport("crypt32", EntryPoint = "CryptSIPPutSignedDataMsg", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPPutSignedDataMsg([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD *")] uint* pdwIndex, [NativeTypeName("DWORD")] uint cbSignedDataMsg, [NativeTypeName("BYTE *")] byte* pbSignedDataMsg);

        [DllImport("crypt32", EntryPoint = "CryptSIPCreateIndirectData", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPCreateIndirectData([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD *")] uint* pcbIndirectData, [NativeTypeName("SIP_INDIRECT_DATA *")] SIP_INDIRECT_DATA* pIndirectData);

        [DllImport("crypt32", EntryPoint = "CryptSIPVerifyIndirectData", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPVerifyIndirectData([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("SIP_INDIRECT_DATA *")] SIP_INDIRECT_DATA* pIndirectData);

        [DllImport("crypt32", EntryPoint = "CryptSIPRemoveSignedDataMsg", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPRemoveSignedDataMsg([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD")] uint dwIndex);

        [DllImport("crypt32", EntryPoint = "CryptSIPLoad", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPLoad([NativeTypeName("const GUID *")] Guid* pgSubject, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("SIP_DISPATCH_INFO *")] SIP_DISPATCH_INFO* pSipDispatch);

        [DllImport("crypt32", EntryPoint = "CryptSIPRetrieveSubjectGuid", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPRetrieveSubjectGuid([NativeTypeName("LPCWSTR")] ushort* FileName, [NativeTypeName("HANDLE")] IntPtr hFileIn, [NativeTypeName("GUID *")] Guid* pgSubject);

        [DllImport("crypt32", EntryPoint = "CryptSIPRetrieveSubjectGuidForCatalogFile", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPRetrieveSubjectGuidForCatalogFile([NativeTypeName("LPCWSTR")] ushort* FileName, [NativeTypeName("HANDLE")] IntPtr hFileIn, [NativeTypeName("GUID *")] Guid* pgSubject);

        [DllImport("crypt32", EntryPoint = "CryptSIPAddProvider", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPAddProvider([NativeTypeName("SIP_ADD_NEWPROVIDER *")] SIP_ADD_NEWPROVIDER* psNewProv);

        [DllImport("crypt32", EntryPoint = "CryptSIPRemoveProvider", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPRemoveProvider([NativeTypeName("GUID *")] Guid* pgProv);

        [DllImport("crypt32", EntryPoint = "CryptSIPGetCaps", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPGetCaps([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjInfo, [NativeTypeName("SIP_CAP_SET *")] SIP_CAP_SET_V3* pCaps);

        [DllImport("crypt32", EntryPoint = "CryptSIPGetSealedDigest", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPGetSealedDigest([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("const BYTE *")] byte* pSig, [NativeTypeName("DWORD")] uint dwSig, [NativeTypeName("BYTE *")] byte* pbDigest, [NativeTypeName("DWORD *")] uint* pcbDigest);
    }
}
