// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24FA67D5-D1D0-4DC5-995C-C0EFDC191FB5")]
    [NativeTypeName("struct IMFMediaKeySession : IUnknown")]
    public unsafe partial struct IMFMediaKeySession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, uint>)(lpVtbl[1]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, uint>)(lpVtbl[2]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetError([NativeTypeName("USHORT *")] ushort* code, [NativeTypeName("DWORD *")] uint* systemCode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)(lpVtbl[3]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), code, systemCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort**, int>)(lpVtbl[4]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), keySystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SessionId([NativeTypeName("BSTR *")] ushort** sessionId)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort**, int>)(lpVtbl[5]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), sessionId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("const BYTE *")] byte* key, [NativeTypeName("DWORD")] uint cb)
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, byte*, uint, int>)(lpVtbl[6]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this), key, cb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, int>)(lpVtbl[7]))((IMFMediaKeySession*)Unsafe.AsPointer(ref this));
        }
    }
}
