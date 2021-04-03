// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ADE0FD60-D19D-11D2-ABF6-00A0C905F375")]
    [NativeTypeName("struct IGraphConfigCallback : IUnknown")]
    public unsafe partial struct IGraphConfigCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGraphConfigCallback*, Guid*, void**, int>)(lpVtbl[0]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGraphConfigCallback*, uint>)(lpVtbl[1]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGraphConfigCallback*, uint>)(lpVtbl[2]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reconfigure([NativeTypeName("PVOID")] void* pvContext, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IGraphConfigCallback*, void*, uint, int>)(lpVtbl[3]))((IGraphConfigCallback*)Unsafe.AsPointer(ref this), pvContext, dwFlags);
        }
    }
}
