// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87BE986C-10BE-4943-BF48-4B54CE1983A2")]
    [NativeTypeName("struct IMFContentDecryptionModule : IUnknown")]
    public unsafe partial struct IMFContentDecryptionModule
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, uint>)(lpVtbl[1]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, uint>)(lpVtbl[2]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContentEnabler([NativeTypeName("IMFContentEnabler *")] IMFContentEnabler* contentEnabler, [NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* result)
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, IMFContentEnabler*, IMFAsyncResult*, int>)(lpVtbl[3]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), contentEnabler, result);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSuspendNotify([NativeTypeName("IMFCdmSuspendNotify **")] IMFCdmSuspendNotify** notify)
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, IMFCdmSuspendNotify**, int>)(lpVtbl[4]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), notify);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPMPHostApp([NativeTypeName("IMFPMPHostApp *")] IMFPMPHostApp* pmpHostApp)
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, IMFPMPHostApp*, int>)(lpVtbl[5]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), pmpHostApp);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSession(MF_MEDIAKEYSESSION_TYPE sessionType, [NativeTypeName("IMFContentDecryptionModuleSessionCallbacks *")] IMFContentDecryptionModuleSessionCallbacks* callbacks, [NativeTypeName("IMFContentDecryptionModuleSession **")] IMFContentDecryptionModuleSession** session)
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, MF_MEDIAKEYSESSION_TYPE, IMFContentDecryptionModuleSessionCallbacks*, IMFContentDecryptionModuleSession**, int>)(lpVtbl[6]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), sessionType, callbacks, session);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetServerCertificate([NativeTypeName("const BYTE *")] byte* certificate, [NativeTypeName("DWORD")] uint certificateSize)
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, byte*, uint, int>)(lpVtbl[7]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), certificate, certificateSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTrustedInput([NativeTypeName("const BYTE *")] byte* contentInitData, [NativeTypeName("DWORD")] uint contentInitDataSize, [NativeTypeName("IMFTrustedInput **")] IMFTrustedInput** trustedInput)
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, byte*, uint, IMFTrustedInput**, int>)(lpVtbl[8]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), contentInitData, contentInitDataSize, trustedInput);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProtectionSystemIds([NativeTypeName("GUID **")] Guid** systemIds, [NativeTypeName("DWORD *")] uint* count)
        {
            return ((delegate* stdcall<IMFContentDecryptionModule*, Guid**, uint*, int>)(lpVtbl[9]))((IMFContentDecryptionModule*)Unsafe.AsPointer(ref this), systemIds, count);
        }
    }
}
