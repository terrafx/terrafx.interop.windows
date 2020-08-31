// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("68961E68-832B-41EA-BC91-63593F3E70E3")]
    [NativeTypeName("struct IMediaSample2Config : IUnknown")]
    public unsafe partial struct IMediaSample2Config
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMediaSample2Config*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSample2Config*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMediaSample2Config*, uint>)(lpVtbl[1]))((IMediaSample2Config*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMediaSample2Config*, uint>)(lpVtbl[2]))((IMediaSample2Config*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurface([NativeTypeName("IUnknown **")] IUnknown** ppDirect3DSurface9)
        {
            return ((delegate* stdcall<IMediaSample2Config*, IUnknown**, int>)(lpVtbl[3]))((IMediaSample2Config*)Unsafe.AsPointer(ref this), ppDirect3DSurface9);
        }
    }
}
