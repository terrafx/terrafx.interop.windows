// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E93DCF6C-4B07-4E1E-8123-AA16ED6EADF5")]
    [NativeTypeName("struct IMFMediaTypeHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaTypeHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, uint>)(lpVtbl[1]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, uint>)(lpVtbl[2]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT IsMediaTypeSupported(IMFMediaType* pMediaType, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, IMFMediaType*, IMFMediaType**, int>)(lpVtbl[3]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pMediaType, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwTypeCount)
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, uint*, int>)(lpVtbl[4]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pdwTypeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetMediaTypeByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), dwIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetCurrentMediaType(IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, IMFMediaType*, int>)(lpVtbl[6]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetCurrentMediaType(IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, IMFMediaType**, int>)(lpVtbl[7]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetMajorType(Guid* pguidMajorType)
        {
            return ((delegate* unmanaged<IMFMediaTypeHandler*, Guid*, int>)(lpVtbl[8]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pguidMajorType);
        }
    }
}
