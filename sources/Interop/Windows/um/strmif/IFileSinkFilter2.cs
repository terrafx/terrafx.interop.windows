// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00855B90-CE1B-11D0-BD4F-00A0C911CE86")]
    [NativeTypeName("struct IFileSinkFilter2 : IFileSinkFilter")]
    public unsafe partial struct IFileSinkFilter2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IFileSinkFilter2*, Guid*, void**, int>)(lpVtbl[0]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IFileSinkFilter2*, uint>)(lpVtbl[1]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IFileSinkFilter2*, uint>)(lpVtbl[2]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFileName([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IFileSinkFilter2*, ushort*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), pszFileName, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName, [NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IFileSinkFilter2*, ushort**, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), ppszFileName, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMode([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IFileSinkFilter2*, uint, int>)(lpVtbl[5]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMode([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* stdcall<IFileSinkFilter2*, uint*, int>)(lpVtbl[6]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), pdwFlags);
        }
    }
}
