// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8E1C39A1-DE53-11CF-AA63-0080C744528D")]
    [NativeTypeName("struct IAMOpenProgress : IUnknown")]
    public unsafe partial struct IAMOpenProgress
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMOpenProgress*, Guid*, void**, int>)(lpVtbl[0]))((IAMOpenProgress*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMOpenProgress*, uint>)(lpVtbl[1]))((IAMOpenProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMOpenProgress*, uint>)(lpVtbl[2]))((IAMOpenProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryProgress([NativeTypeName("LONGLONG *")] long* pllTotal, [NativeTypeName("LONGLONG *")] long* pllCurrent)
        {
            return ((delegate* stdcall<IAMOpenProgress*, long*, long*, int>)(lpVtbl[3]))((IAMOpenProgress*)Unsafe.AsPointer(ref this), pllTotal, pllCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AbortOperation()
        {
            return ((delegate* stdcall<IAMOpenProgress*, int>)(lpVtbl[4]))((IAMOpenProgress*)Unsafe.AsPointer(ref this));
        }
    }
}
