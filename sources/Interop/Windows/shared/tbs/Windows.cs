// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsi_Context_Create([NativeTypeName("PCTBS_CONTEXT_PARAMS")] TBS_CONTEXT_PARAMS* pContextParams, [NativeTypeName("PTBS_HCONTEXT")] void** phContext);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsip_Context_Close([NativeTypeName("TBS_HCONTEXT")] void* hContext);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsip_Submit_Command([NativeTypeName("TBS_HCONTEXT")] void* hContext, [NativeTypeName("TBS_COMMAND_LOCALITY")] uint Locality, [NativeTypeName("TBS_COMMAND_PRIORITY")] uint Priority, [NativeTypeName("PCBYTE")] byte* pabCommand, [NativeTypeName("UINT32")] uint cbCommand, [NativeTypeName("PBYTE")] byte* pabResult, [NativeTypeName("PUINT32")] uint* pcbResult);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsip_Cancel_Commands([NativeTypeName("TBS_HCONTEXT")] void* hContext);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsi_Physical_Presence_Command([NativeTypeName("TBS_HCONTEXT")] void* hContext, [NativeTypeName("PCBYTE")] byte* pabInput, [NativeTypeName("UINT32")] uint cbInput, [NativeTypeName("PBYTE")] byte* pabOutput, [NativeTypeName("PUINT32")] uint* pcbOutput);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsi_Get_TCG_Log([NativeTypeName("TBS_HCONTEXT")] void* hContext, [NativeTypeName("PBYTE")] byte* pOutputBuf, [NativeTypeName("PUINT32")] uint* pOutputBufLen);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsi_GetDeviceInfo([NativeTypeName("UINT32")] uint Size, [NativeTypeName("PVOID")] void* Info);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsi_Get_OwnerAuth([NativeTypeName("TBS_HCONTEXT")] void* hContext, [NativeTypeName("TBS_OWNERAUTH_TYPE")] uint ownerauthType, [NativeTypeName("PBYTE")] byte* pOutputBuf, [NativeTypeName("PUINT32")] uint* pOutputBufLen);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsi_Revoke_Attestation();

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDeviceID([NativeTypeName("PBYTE")] byte* pbWindowsAIK, [NativeTypeName("UINT32")] uint cbWindowsAIK, [NativeTypeName("PUINT32")] uint* pcbResult, [NativeTypeName("BOOL *")] int* pfProtectedByTPM);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDeviceIDString([NativeTypeName("PWSTR")] ushort* pszWindowsAIK, [NativeTypeName("UINT32")] uint cchWindowsAIK, [NativeTypeName("PUINT32")] uint* pcchResult, [NativeTypeName("BOOL *")] int* pfProtectedByTPM);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsi_Create_Windows_Key([NativeTypeName("TBS_HANDLE")] uint keyHandle);

        [DllImport("tbs", ExactSpelling = true)]
        [return: NativeTypeName("TBS_RESULT")]
        public static extern uint Tbsi_Get_TCG_Log_Ex([NativeTypeName("UINT32")] uint logType, [NativeTypeName("PBYTE")] byte* pbOutput, [NativeTypeName("PUINT32")] uint* pcbOutput);

        [NativeTypeName("#define TBS_CONTEXT_VERSION_ONE 1")]
        public const int TBS_CONTEXT_VERSION_ONE = 1;

        [NativeTypeName("#define TBS_COMMAND_PRIORITY_LOW 100")]
        public const int TBS_COMMAND_PRIORITY_LOW = 100;

        [NativeTypeName("#define TBS_COMMAND_PRIORITY_NORMAL 200")]
        public const int TBS_COMMAND_PRIORITY_NORMAL = 200;

        [NativeTypeName("#define TBS_COMMAND_PRIORITY_HIGH 300")]
        public const int TBS_COMMAND_PRIORITY_HIGH = 300;

        [NativeTypeName("#define TBS_COMMAND_PRIORITY_SYSTEM 400")]
        public const int TBS_COMMAND_PRIORITY_SYSTEM = 400;

        [NativeTypeName("#define TBS_COMMAND_PRIORITY_MAX 0x80000000")]
        public const uint TBS_COMMAND_PRIORITY_MAX = 0x80000000;

        [NativeTypeName("#define TBS_COMMAND_LOCALITY_ZERO 0")]
        public const int TBS_COMMAND_LOCALITY_ZERO = 0;

        [NativeTypeName("#define TBS_COMMAND_LOCALITY_ONE 1")]
        public const int TBS_COMMAND_LOCALITY_ONE = 1;

        [NativeTypeName("#define TBS_COMMAND_LOCALITY_TWO 2")]
        public const int TBS_COMMAND_LOCALITY_TWO = 2;

        [NativeTypeName("#define TBS_COMMAND_LOCALITY_THREE 3")]
        public const int TBS_COMMAND_LOCALITY_THREE = 3;

        [NativeTypeName("#define TBS_COMMAND_LOCALITY_FOUR 4")]
        public const int TBS_COMMAND_LOCALITY_FOUR = 4;

        [NativeTypeName("#define TBS_SUCCESS 0")]
        public const int TBS_SUCCESS = 0;

        [NativeTypeName("#define TBS_IN_OUT_BUF_SIZE_MAX (256*1024)")]
        public const int TBS_IN_OUT_BUF_SIZE_MAX = (256 * 1024);

        [NativeTypeName("#define TBS_OWNERAUTH_TYPE_FULL 1")]
        public const int TBS_OWNERAUTH_TYPE_FULL = 1;

        [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ADMIN 2")]
        public const int TBS_OWNERAUTH_TYPE_ADMIN = 2;

        [NativeTypeName("#define TBS_OWNERAUTH_TYPE_USER 3")]
        public const int TBS_OWNERAUTH_TYPE_USER = 3;

        [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ENDORSEMENT 4")]
        public const int TBS_OWNERAUTH_TYPE_ENDORSEMENT = 4;

        [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ENDORSEMENT_20 12")]
        public const int TBS_OWNERAUTH_TYPE_ENDORSEMENT_20 = 12;

        [NativeTypeName("#define TBS_OWNERAUTH_TYPE_STORAGE_20 13")]
        public const int TBS_OWNERAUTH_TYPE_STORAGE_20 = 13;

        [NativeTypeName("#define TBS_CONTEXT_VERSION_TWO 2")]
        public const int TBS_CONTEXT_VERSION_TWO = 2;

        [NativeTypeName("#define TPM_WNF_INFO_CLEAR_SUCCESSFUL 0x00000001")]
        public const int TPM_WNF_INFO_CLEAR_SUCCESSFUL = 0x00000001;

        [NativeTypeName("#define TPM_WNF_INFO_OWNERSHIP_SUCCESSFUL 0x00000002")]
        public const int TPM_WNF_INFO_OWNERSHIP_SUCCESSFUL = 0x00000002;

        [NativeTypeName("#define TPM_WNF_INFO_NO_REBOOT_REQUIRED 1")]
        public const int TPM_WNF_INFO_NO_REBOOT_REQUIRED = 1;

        [NativeTypeName("#define TPM_VERSION_UNKNOWN 0")]
        public const int TPM_VERSION_UNKNOWN = 0;

        [NativeTypeName("#define TPM_VERSION_12 1")]
        public const int TPM_VERSION_12 = 1;

        [NativeTypeName("#define TPM_VERSION_20 2")]
        public const int TPM_VERSION_20 = 2;

        [NativeTypeName("#define TPM_IFTYPE_UNKNOWN 0")]
        public const int TPM_IFTYPE_UNKNOWN = 0;

        [NativeTypeName("#define TPM_IFTYPE_1 1")]
        public const int TPM_IFTYPE_1 = 1;

        [NativeTypeName("#define TPM_IFTYPE_TRUSTZONE 2")]
        public const int TPM_IFTYPE_TRUSTZONE = 2;

        [NativeTypeName("#define TPM_IFTYPE_HW 3")]
        public const int TPM_IFTYPE_HW = 3;

        [NativeTypeName("#define TPM_IFTYPE_EMULATOR 4")]
        public const int TPM_IFTYPE_EMULATOR = 4;

        [NativeTypeName("#define TPM_IFTYPE_SPB 5")]
        public const int TPM_IFTYPE_SPB = 5;

        [NativeTypeName("#define TBS_TCGLOG_SRTM_CURRENT 0")]
        public const int TBS_TCGLOG_SRTM_CURRENT = 0;

        [NativeTypeName("#define TBS_TCGLOG_DRTM_CURRENT 1")]
        public const int TBS_TCGLOG_DRTM_CURRENT = 1;

        [NativeTypeName("#define TBS_TCGLOG_SRTM_BOOT 2")]
        public const int TBS_TCGLOG_SRTM_BOOT = 2;

        [NativeTypeName("#define TBS_TCGLOG_SRTM_RESUME 3")]
        public const int TBS_TCGLOG_SRTM_RESUME = 3;

        [NativeTypeName("#define TBS_TCGLOG_DRTM_BOOT 4")]
        public const int TBS_TCGLOG_DRTM_BOOT = 4;

        [NativeTypeName("#define TBS_TCGLOG_DRTM_RESUME 5")]
        public const int TBS_TCGLOG_DRTM_RESUME = 5;
    }
}
