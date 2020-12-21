// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45892507-AD66-4DE2-83A2-ACBB13CD8D43")]
    [NativeTypeName("struct IMFMediaKeys2 : IMFMediaKeys")]
    public unsafe partial struct IMFMediaKeys2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, uint>)(lpVtbl[1]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, uint>)(lpVtbl[2]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSession([NativeTypeName("BSTR")] ushort* mimeType, [NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const BYTE *")] byte* customData, [NativeTypeName("DWORD")] uint cbCustomData, [NativeTypeName("IMFMediaKeySessionNotify *")] IMFMediaKeySessionNotify* notify, [NativeTypeName("IMFMediaKeySession **")] IMFMediaKeySession** ppSession)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, ushort*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)(lpVtbl[3]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this), mimeType, initData, cb, customData, cbCustomData, notify, ppSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, ushort**, int>)(lpVtbl[4]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this), keySystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, int>)(lpVtbl[5]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSuspendNotify([NativeTypeName("IMFCdmSuspendNotify **")] IMFCdmSuspendNotify** notify)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, IMFCdmSuspendNotify**, int>)(lpVtbl[6]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this), notify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSession2(MF_MEDIAKEYSESSION_TYPE eSessionType, [NativeTypeName("IMFMediaKeySessionNotify2 *")] IMFMediaKeySessionNotify2* pMFMediaKeySessionNotify2, [NativeTypeName("IMFMediaKeySession2 **")] IMFMediaKeySession2** ppSession)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2*, IMFMediaKeySession2**, int>)(lpVtbl[7]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this), eSessionType, pMFMediaKeySessionNotify2, ppSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetServerCertificate([NativeTypeName("const BYTE *")] byte* pbServerCertificate, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, byte*, uint, int>)(lpVtbl[8]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this), pbServerCertificate, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDOMException([NativeTypeName("HRESULT")] int systemCode, [NativeTypeName("HRESULT *")] int* code)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeys2*, int, int*, int>)(lpVtbl[9]))((IMFMediaKeys2*)Unsafe.AsPointer(ref this), systemCode, code);
        }
    }
}
