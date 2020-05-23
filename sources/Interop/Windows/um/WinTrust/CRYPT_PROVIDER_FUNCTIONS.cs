// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PROVIDER_FUNCTIONS
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("PFN_CPD_MEM_ALLOC")]
        public IntPtr pfnAlloc;

        [NativeTypeName("PFN_CPD_MEM_FREE")]
        public IntPtr pfnFree;

        [NativeTypeName("PFN_CPD_ADD_STORE")]
        public IntPtr pfnAddStore2Chain;

        [NativeTypeName("PFN_CPD_ADD_SGNR")]
        public IntPtr pfnAddSgnr2Chain;

        [NativeTypeName("PFN_CPD_ADD_CERT")]
        public IntPtr pfnAddCert2Chain;

        [NativeTypeName("PFN_CPD_ADD_PRIVDATA")]
        public IntPtr pfnAddPrivData2Chain;

        [NativeTypeName("PFN_PROVIDER_INIT_CALL")]
        public IntPtr pfnInitialize;

        [NativeTypeName("PFN_PROVIDER_OBJTRUST_CALL")]
        public IntPtr pfnObjectTrust;

        [NativeTypeName("PFN_PROVIDER_SIGTRUST_CALL")]
        public IntPtr pfnSignatureTrust;

        [NativeTypeName("PFN_PROVIDER_CERTTRUST_CALL")]
        public IntPtr pfnCertificateTrust;

        [NativeTypeName("PFN_PROVIDER_FINALPOLICY_CALL")]
        public IntPtr pfnFinalPolicy;

        [NativeTypeName("PFN_PROVIDER_CERTCHKPOLICY_CALL")]
        public IntPtr pfnCertCheckPolicy;

        [NativeTypeName("PFN_PROVIDER_TESTFINALPOLICY_CALL")]
        public IntPtr pfnTestFinalPolicy;

        [NativeTypeName("struct _CRYPT_PROVUI_FUNCS *")]
        public CRYPT_PROVUI_FUNCS* psUIpfns;

        [NativeTypeName("PFN_PROVIDER_CLEANUP_CALL")]
        public IntPtr pfnCleanupPolicy;
    }
}
