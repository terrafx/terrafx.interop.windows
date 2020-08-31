// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E93DCF6C-4B07-4E1E-8123-AA16ED6EADF5")]
    [NativeTypeName("struct IMFMediaTypeHandler : IUnknown")]
    public unsafe partial struct IMFMediaTypeHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, uint>)(lpVtbl[1]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, uint>)(lpVtbl[2]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsMediaTypeSupported([NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, IMFMediaType*, IMFMediaType**, int>)(lpVtbl[3]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pMediaType, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwTypeCount)
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, uint*, int>)(lpVtbl[4]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pdwTypeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaTypeByIndex([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType)
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), dwIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType)
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, IMFMediaType*, int>)(lpVtbl[6]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentMediaType([NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, IMFMediaType**, int>)(lpVtbl[7]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMajorType([NativeTypeName("GUID *")] Guid* pguidMajorType)
        {
            return ((delegate* stdcall<IMFMediaTypeHandler*, Guid*, int>)(lpVtbl[8]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pguidMajorType);
        }
    }
}
