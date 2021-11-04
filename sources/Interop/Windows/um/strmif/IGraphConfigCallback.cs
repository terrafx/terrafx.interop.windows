// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ADE0FD60-D19D-11D2-ABF6-00A0C905F375")]
    [NativeTypeName("struct IGraphConfigCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGraphConfigCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGraphConfigCallback*, Guid*, void**, int>)(lpVtbl[0]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGraphConfigCallback*, uint>)(lpVtbl[1]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGraphConfigCallback*, uint>)(lpVtbl[2]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Reconfigure([NativeTypeName("PVOID")] void* pvContext, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IGraphConfigCallback*, void*, uint, int>)(lpVtbl[3]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this), pvContext, dwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphConfigCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphConfigCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphConfigCallback*, uint> Release;

            [NativeTypeName("HRESULT (PVOID, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IGraphConfigCallback*, void*, uint, int> Reconfigure;
        }
    }
}
