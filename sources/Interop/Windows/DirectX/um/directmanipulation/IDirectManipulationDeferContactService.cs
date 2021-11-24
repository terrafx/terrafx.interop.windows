// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("652D5C71-FE60-4A98-BE70-E5F21291E7F1")]
[NativeTypeName("struct IDirectManipulationDeferContactService : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDirectManipulationDeferContactService : IDirectManipulationDeferContactService.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint>)(lpVtbl[1]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint>)(lpVtbl[2]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DeferContact([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint timeout)
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint, uint, int>)(lpVtbl[3]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId, timeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CancelContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint, int>)(lpVtbl[4]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelDeferral([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint, int>)(lpVtbl[5]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DeferContact([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint timeout);

        [VtblIndex(4)]
        HRESULT CancelContact([NativeTypeName("UINT32")] uint pointerId);

        [VtblIndex(5)]
        HRESULT CancelDeferral([NativeTypeName("UINT32")] uint pointerId);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationDeferContactService*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationDeferContactService*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationDeferContactService*, uint> Release;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationDeferContactService*, uint, uint, int> DeferContact;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationDeferContactService*, uint, int> CancelContact;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationDeferContactService*, uint, int> CancelDeferral;
    }
}
