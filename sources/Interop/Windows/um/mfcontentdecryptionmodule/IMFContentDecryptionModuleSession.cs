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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, uint>)(lpVtbl[1]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, uint>)(lpVtbl[2]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSessionId([NativeTypeName("LPWSTR *")] ushort** sessionId)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, ushort**, int>)(lpVtbl[3]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), sessionId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExpiration(double* expiration)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, double*, int>)(lpVtbl[4]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), expiration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKeyStatuses(MFMediaKeyStatus** keyStatuses, [NativeTypeName("UINT *")] uint* numKeyStatuses)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, MFMediaKeyStatus**, uint*, int>)(lpVtbl[5]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), keyStatuses, numKeyStatuses);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPCWSTR")] ushort* sessionId, [NativeTypeName("BOOL *")] int* loaded)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, ushort*, int*, int>)(lpVtbl[6]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), sessionId, loaded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GenerateRequest([NativeTypeName("LPCWSTR")] ushort* initDataType, [NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint initDataSize)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, ushort*, byte*, uint, int>)(lpVtbl[7]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), initDataType, initData, initDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("const BYTE *")] byte* response, [NativeTypeName("DWORD")] uint responseSize)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, byte*, uint, int>)(lpVtbl[8]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), response, responseSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, int>)(lpVtbl[9]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleSession*, int>)(lpVtbl[10]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
        }
    }
}
