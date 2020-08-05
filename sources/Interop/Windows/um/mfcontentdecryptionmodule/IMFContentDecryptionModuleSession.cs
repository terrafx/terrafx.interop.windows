// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4E233EFD-1DD2-49E8-B577-D63EEE4C0D33")]
    [NativeTypeName("struct IMFContentDecryptionModuleSession : IUnknown")]
    public unsafe partial struct IMFContentDecryptionModuleSession
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, uint>)(lpVtbl[1]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, uint>)(lpVtbl[2]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSessionId([NativeTypeName("LPWSTR *")] ushort** sessionId)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, ushort**, int>)(lpVtbl[3]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), sessionId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExpiration([NativeTypeName("double *")] double* expiration)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, double*, int>)(lpVtbl[4]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), expiration);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKeyStatuses([NativeTypeName("MFMediaKeyStatus **")] MFMediaKeyStatus** keyStatuses, [NativeTypeName("UINT *")] uint* numKeyStatuses)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, MFMediaKeyStatus**, uint*, int>)(lpVtbl[5]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), keyStatuses, numKeyStatuses);
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPCWSTR")] ushort* sessionId, [NativeTypeName("BOOL *")] int* loaded)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, ushort*, int*, int>)(lpVtbl[6]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), sessionId, loaded);
        }

        [return: NativeTypeName("HRESULT")]
        public int GenerateRequest([NativeTypeName("LPCWSTR")] ushort* initDataType, [NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint initDataSize)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, ushort*, byte*, uint, int>)(lpVtbl[7]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), initDataType, initData, initDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("const BYTE *")] byte* response, [NativeTypeName("DWORD")] uint responseSize)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, byte*, uint, int>)(lpVtbl[8]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), response, responseSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, int>)(lpVtbl[9]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Remove()
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSession*, int>)(lpVtbl[10]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
        }
    }
}
