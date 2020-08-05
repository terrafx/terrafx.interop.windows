// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D19F8E98-B126-4446-890C-5DCB7AD71453")]
    [NativeTypeName("struct IMFInputTrustAuthority : IUnknown")]
    public unsafe partial struct IMFInputTrustAuthority
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, Guid*, void**, int>)(lpVtbl[0]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, uint>)(lpVtbl[1]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, uint>)(lpVtbl[2]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDecrypter([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, Guid*, void**, int>)(lpVtbl[3]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestAccess(MFPOLICYMANAGER_ACTION Action, [NativeTypeName("IMFActivate **")] IMFActivate** ppContentEnablerActivate)
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, MFPOLICYMANAGER_ACTION, IMFActivate**, int>)(lpVtbl[4]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), Action, ppContentEnablerActivate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPolicy(MFPOLICYMANAGER_ACTION Action, [NativeTypeName("IMFOutputPolicy **")] IMFOutputPolicy** ppPolicy)
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, MFPOLICYMANAGER_ACTION, IMFOutputPolicy**, int>)(lpVtbl[5]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), Action, ppPolicy);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindAccess([NativeTypeName("MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS *")] MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS* pParam)
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS*, int>)(lpVtbl[6]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), pParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateAccess([NativeTypeName("MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS *")] MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS* pParam)
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS*, int>)(lpVtbl[7]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this), pParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IMFInputTrustAuthority*, int>)(lpVtbl[8]))((IMFInputTrustAuthority*)Unsafe.AsPointer(ref this));
        }
    }
}
