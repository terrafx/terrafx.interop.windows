// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Crypt32
    {
        private const string LibraryPath = "crypt32";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPGetSignedDataMsg", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPGetSignedDataMsg([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD *")] uint* pdwEncodingType, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pcbSignedDataMsg, [NativeTypeName("BYTE *")] byte* pbSignedDataMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPPutSignedDataMsg", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPPutSignedDataMsg([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD *")] uint* pdwIndex, [NativeTypeName("DWORD")] uint cbSignedDataMsg, [NativeTypeName("BYTE *")] byte* pbSignedDataMsg);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPCreateIndirectData", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPCreateIndirectData([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD *")] uint* pcbIndirectData, [NativeTypeName("SIP_INDIRECT_DATA *")] SIP_INDIRECT_DATA* pIndirectData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPVerifyIndirectData", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPVerifyIndirectData([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("SIP_INDIRECT_DATA *")] SIP_INDIRECT_DATA* pIndirectData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPRemoveSignedDataMsg", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPRemoveSignedDataMsg([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD")] uint dwIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPLoad", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPLoad([NativeTypeName("const GUID *")] Guid* pgSubject, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("SIP_DISPATCH_INFO *")] SIP_DISPATCH_INFO* pSipDispatch);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPRetrieveSubjectGuid", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPRetrieveSubjectGuid([NativeTypeName("LPCWSTR")] ushort* FileName, [NativeTypeName("HANDLE")] IntPtr hFileIn, [NativeTypeName("GUID *")] Guid* pgSubject);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPRetrieveSubjectGuidForCatalogFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPRetrieveSubjectGuidForCatalogFile([NativeTypeName("LPCWSTR")] ushort* FileName, [NativeTypeName("HANDLE")] IntPtr hFileIn, [NativeTypeName("GUID *")] Guid* pgSubject);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPAddProvider", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPAddProvider([NativeTypeName("SIP_ADD_NEWPROVIDER *")] SIP_ADD_NEWPROVIDER* psNewProv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPRemoveProvider", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPRemoveProvider([NativeTypeName("GUID *")] Guid* pgProv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPGetCaps", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPGetCaps([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjInfo, [NativeTypeName("SIP_CAP_SET *")] SIP_CAP_SET_V3* pCaps);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CryptSIPGetSealedDigest", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CryptSIPGetSealedDigest([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("const BYTE *")] byte* pSig, [NativeTypeName("DWORD")] uint dwSig, [NativeTypeName("BYTE *")] byte* pbDigest, [NativeTypeName("DWORD *")] uint* pcbDigest);
    }
}
