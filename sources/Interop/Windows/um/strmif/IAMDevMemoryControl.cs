// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C6545BF1-E76B-11D0-BD52-00A0C911CE86")]
    [NativeTypeName("struct IAMDevMemoryControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMDevMemoryControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMDevMemoryControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMDevMemoryControl*, uint>)(lpVtbl[1]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMDevMemoryControl*, uint>)(lpVtbl[2]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryWriteSync()
        {
            return ((delegate* unmanaged<IAMDevMemoryControl*, int>)(lpVtbl[3]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT WriteSync()
        {
            return ((delegate* unmanaged<IAMDevMemoryControl*, int>)(lpVtbl[4]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDevId([NativeTypeName("DWORD *")] uint* pdwDevId)
        {
            return ((delegate* unmanaged<IAMDevMemoryControl*, uint*, int>)(lpVtbl[5]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this), pdwDevId);
        }
    }
}
