// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("045FA593-8799-42B8-BC8D-8968C6453507")]
    [NativeTypeName("struct IMFMediaBuffer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint>)(lpVtbl[1]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint>)(lpVtbl[2]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Lock(byte** ppbBuffer, [NativeTypeName("DWORD *")] uint* pcbMaxLength, [NativeTypeName("DWORD *")] uint* pcbCurrentLength)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, byte**, uint*, uint*, int>)(lpVtbl[3]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), ppbBuffer, pcbMaxLength, pcbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Unlock()
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, int>)(lpVtbl[4]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint*, int>)(lpVtbl[5]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), pcbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint, int>)(lpVtbl[6]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), cbCurrentLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
        {
            return ((delegate* unmanaged<IMFMediaBuffer*, uint*, int>)(lpVtbl[7]))((IMFMediaBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
        }
    }
}
