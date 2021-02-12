// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1960960-17F5-11D1-ABE1-00A0C905F375")]
    [NativeTypeName("struct IAMStreamSelect : IUnknown")]
    public unsafe partial struct IAMStreamSelect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAMStreamSelect*, Guid*, void**, int>)(lpVtbl[0]))((IAMStreamSelect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMStreamSelect*, uint>)(lpVtbl[1]))((IAMStreamSelect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMStreamSelect*, uint>)(lpVtbl[2]))((IAMStreamSelect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Count([NativeTypeName("DWORD *")] uint* pcStreams)
        {
            return ((delegate* unmanaged<IAMStreamSelect*, uint*, int>)(lpVtbl[3]))((IAMStreamSelect*)Unsafe.AsPointer(ref this), pcStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Info([NativeTypeName("long")] int lIndex, [NativeTypeName("AM_MEDIA_TYPE **")] AM_MEDIA_TYPE** ppmt, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LCID *")] uint* plcid, [NativeTypeName("DWORD *")] uint* pdwGroup, [NativeTypeName("LPWSTR *")] ushort** ppszName, [NativeTypeName("IUnknown **")] IUnknown** ppObject, [NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IAMStreamSelect*, int, AM_MEDIA_TYPE**, uint*, uint*, uint*, ushort**, IUnknown**, IUnknown**, int>)(lpVtbl[4]))((IAMStreamSelect*)Unsafe.AsPointer(ref this), lIndex, ppmt, pdwFlags, plcid, pdwGroup, ppszName, ppObject, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Enable([NativeTypeName("long")] int lIndex, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IAMStreamSelect*, int, uint, int>)(lpVtbl[5]))((IAMStreamSelect*)Unsafe.AsPointer(ref this), lIndex, dwFlags);
        }
    }
}
