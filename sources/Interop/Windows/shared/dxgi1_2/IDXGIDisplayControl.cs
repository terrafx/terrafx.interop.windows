// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C")]
    [NativeTypeName("struct IDXGIDisplayControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDXGIDisplayControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIDisplayControl*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIDisplayControl*, uint>)(lpVtbl[1]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIDisplayControl*, uint>)(lpVtbl[2]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public BOOL IsStereoEnabled()
        {
            return ((delegate* unmanaged<IDXGIDisplayControl*, int>)(lpVtbl[3]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetStereoEnabled(BOOL enabled)
        {
            ((delegate* unmanaged<IDXGIDisplayControl*, BOOL, void>)(lpVtbl[4]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), enabled);
        }
    }
}
