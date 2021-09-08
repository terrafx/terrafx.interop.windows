// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A2104830-7C70-11CF-8BCE-00AA00A3F1A6")]
    [NativeTypeName("struct IFileSinkFilter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFileSinkFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSinkFilter*, Guid*, void**, int>)(lpVtbl[0]))((IFileSinkFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSinkFilter*, uint>)(lpVtbl[1]))((IFileSinkFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSinkFilter*, uint>)(lpVtbl[2]))((IFileSinkFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetFileName([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IFileSinkFilter*, ushort*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IFileSinkFilter*)Unsafe.AsPointer(ref this), pszFileName, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName, AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IFileSinkFilter*, ushort**, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IFileSinkFilter*)Unsafe.AsPointer(ref this), ppszFileName, pmt);
        }
    }
}
