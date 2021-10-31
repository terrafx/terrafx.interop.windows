// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPGetSignedDataMsg(SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD *")] uint* pdwEncodingType, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pcbSignedDataMsg, [NativeTypeName("BYTE *")] byte* pbSignedDataMsg);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPPutSignedDataMsg(SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("DWORD *")] uint* pdwIndex, [NativeTypeName("DWORD")] uint cbSignedDataMsg, [NativeTypeName("BYTE *")] byte* pbSignedDataMsg);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPCreateIndirectData(SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD *")] uint* pcbIndirectData, SIP_INDIRECT_DATA* pIndirectData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPVerifyIndirectData(SIP_SUBJECTINFO* pSubjectInfo, SIP_INDIRECT_DATA* pIndirectData);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPRemoveSignedDataMsg(SIP_SUBJECTINFO* pSubjectInfo, [NativeTypeName("DWORD")] uint dwIndex);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPLoad([NativeTypeName("const GUID *")] Guid* pgSubject, [NativeTypeName("DWORD")] uint dwFlags, SIP_DISPATCH_INFO* pSipDispatch);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPRetrieveSubjectGuid([NativeTypeName("LPCWSTR")] ushort* FileName, HANDLE hFileIn, [NativeTypeName("GUID *")] Guid* pgSubject);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPRetrieveSubjectGuidForCatalogFile([NativeTypeName("LPCWSTR")] ushort* FileName, HANDLE hFileIn, [NativeTypeName("GUID *")] Guid* pgSubject);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPAddProvider(SIP_ADD_NEWPROVIDER* psNewProv);

        [DllImport("crypt32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CryptSIPRemoveProvider([NativeTypeName("GUID *")] Guid* pgProv);

        [DllImport("crypt32", ExactSpelling = true)]
        public static extern BOOL CryptSIPGetCaps(SIP_SUBJECTINFO* pSubjInfo, [NativeTypeName("SIP_CAP_SET *")] SIP_CAP_SET_V3* pCaps);

        [NativeTypeName("#define MSSIP_FLAGS_PROHIBIT_RESIZE_ON_CREATE 0x00010000")]
        public const int MSSIP_FLAGS_PROHIBIT_RESIZE_ON_CREATE = 0x00010000;

        [NativeTypeName("#define MSSIP_FLAGS_USE_CATALOG 0x00020000")]
        public const int MSSIP_FLAGS_USE_CATALOG = 0x00020000;

        [NativeTypeName("#define MSSIP_FLAGS_MULTI_HASH 0x00040000")]
        public const int MSSIP_FLAGS_MULTI_HASH = 0x00040000;

        [NativeTypeName("#define SPC_INC_PE_RESOURCES_FLAG 0x80")]
        public const int SPC_INC_PE_RESOURCES_FLAG = 0x80;

        [NativeTypeName("#define SPC_INC_PE_DEBUG_INFO_FLAG 0x40")]
        public const int SPC_INC_PE_DEBUG_INFO_FLAG = 0x40;

        [NativeTypeName("#define SPC_INC_PE_IMPORT_ADDR_TABLE_FLAG 0x20")]
        public const int SPC_INC_PE_IMPORT_ADDR_TABLE_FLAG = 0x20;

        [NativeTypeName("#define SPC_EXC_PE_PAGE_HASHES_FLAG 0x10")]
        public const int SPC_EXC_PE_PAGE_HASHES_FLAG = 0x10;

        [NativeTypeName("#define SPC_INC_PE_PAGE_HASHES_FLAG 0x100")]
        public const int SPC_INC_PE_PAGE_HASHES_FLAG = 0x100;

        [NativeTypeName("#define SPC_DIGEST_GENERATE_FLAG 0x200")]
        public const int SPC_DIGEST_GENERATE_FLAG = 0x200;

        [NativeTypeName("#define SPC_DIGEST_SIGN_FLAG 0x400")]
        public const int SPC_DIGEST_SIGN_FLAG = 0x400;

        [NativeTypeName("#define SPC_DIGEST_SIGN_EX_FLAG 0x4000")]
        public const int SPC_DIGEST_SIGN_EX_FLAG = 0x4000;

        [NativeTypeName("#define SPC_RELAXED_PE_MARKER_CHECK 0x800")]
        public const int SPC_RELAXED_PE_MARKER_CHECK = 0x800;

        [NativeTypeName("#define SPC_MARKER_CHECK_SKIP_SIP_INDIRECT_DATA_FLAG 0x00000001")]
        public const int SPC_MARKER_CHECK_SKIP_SIP_INDIRECT_DATA_FLAG = 0x00000001;

        [NativeTypeName("#define SPC_MARKER_CHECK_CURRENTLY_SUPPORTED_FLAGS SPC_MARKER_CHECK_SKIP_SIP_INDIRECT_DATA_FLAG")]
        public const int SPC_MARKER_CHECK_CURRENTLY_SUPPORTED_FLAGS = 0x00000001;

        [NativeTypeName("#define MSSIP_ADDINFO_NONE 0")]
        public const int MSSIP_ADDINFO_NONE = 0;

        [NativeTypeName("#define MSSIP_ADDINFO_FLAT 1")]
        public const int MSSIP_ADDINFO_FLAT = 1;

        [NativeTypeName("#define MSSIP_ADDINFO_CATMEMBER 2")]
        public const int MSSIP_ADDINFO_CATMEMBER = 2;

        [NativeTypeName("#define MSSIP_ADDINFO_BLOB 3")]
        public const int MSSIP_ADDINFO_BLOB = 3;

        [NativeTypeName("#define MSSIP_ADDINFO_NONMSSIP 500")]
        public const int MSSIP_ADDINFO_NONMSSIP = 500;

        [NativeTypeName("#define SIP_CAP_SET_VERSION_2 2")]
        public const int SIP_CAP_SET_VERSION_2 = 2;

        [NativeTypeName("#define SIP_CAP_SET_VERSION_3 3")]
        public const int SIP_CAP_SET_VERSION_3 = 3;

        [NativeTypeName("#define SIP_CAP_SET_CUR_VER 3")]
        public const int SIP_CAP_SET_CUR_VER = 3;

        [NativeTypeName("#define SIP_CAP_FLAG_SEALING 0x00000001")]
        public const int SIP_CAP_FLAG_SEALING = 0x00000001;

        [NativeTypeName("#define SIP_MAX_MAGIC_NUMBER 4")]
        public const int SIP_MAX_MAGIC_NUMBER = 4;
    }
}
