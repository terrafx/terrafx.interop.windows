// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows8.0")]
[Guid("790B6337-64F8-4FF5-A269-B32BC2AF27A7")]
[NativeTypeName("struct IDirectManipulationUpdateHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectManipulationUpdateHandler : IDirectManipulationUpdateHandler.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationUpdateHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateHandler*, uint>)(lpVtbl[1]))((IDirectManipulationUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateHandler*, uint>)(lpVtbl[2]))((IDirectManipulationUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Update()
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateHandler*, int>)(lpVtbl[3]))((IDirectManipulationUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Update();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationUpdateHandler*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationUpdateHandler*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationUpdateHandler*, uint> Release;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationUpdateHandler*, int> Update;
    }
}
