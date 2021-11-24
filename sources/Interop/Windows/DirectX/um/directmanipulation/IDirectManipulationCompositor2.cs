// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("D38C7822-F1CB-43CB-B4B9-AC0C767A412E")]
[NativeTypeName("struct IDirectManipulationCompositor2 : IDirectManipulationCompositor")]
[NativeInheritance("IDirectManipulationCompositor")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDirectManipulationCompositor2 : IDirectManipulationCompositor2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2*, uint>)(lpVtbl[1]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2*, uint>)(lpVtbl[2]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddContent(IDirectManipulationContent* content, IUnknown* device, IUnknown* parentVisual, IUnknown* childVisual)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationContent*, IUnknown*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), content, device, parentVisual, childVisual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveContent(IDirectManipulationContent* content)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationContent*, int>)(lpVtbl[4]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), content);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetUpdateManager(IDirectManipulationUpdateManager* updateManager)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationUpdateManager*, int>)(lpVtbl[5]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), updateManager);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2*, int>)(lpVtbl[6]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddContentWithCrossProcessChaining(IDirectManipulationPrimaryContent* content, IUnknown* device, IUnknown* parentVisual, IUnknown* childVisual)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationPrimaryContent*, IUnknown*, IUnknown*, IUnknown*, int>)(lpVtbl[7]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), content, device, parentVisual, childVisual);
    }

    public interface Interface : IDirectManipulationCompositor.Interface
    {
        [VtblIndex(7)]
        HRESULT AddContentWithCrossProcessChaining(IDirectManipulationPrimaryContent* content, IUnknown* device, IUnknown* parentVisual, IUnknown* childVisual);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationCompositor2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationCompositor2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationCompositor2*, uint> Release;

        [NativeTypeName("HRESULT (IDirectManipulationContent *, IUnknown *, IUnknown *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationContent*, IUnknown*, IUnknown*, IUnknown*, int> AddContent;

        [NativeTypeName("HRESULT (IDirectManipulationContent *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationContent*, int> RemoveContent;

        [NativeTypeName("HRESULT (IDirectManipulationUpdateManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationUpdateManager*, int> SetUpdateManager;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationCompositor2*, int> Flush;

        [NativeTypeName("HRESULT (IDirectManipulationPrimaryContent *, IUnknown *, IUnknown *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationPrimaryContent*, IUnknown*, IUnknown*, IUnknown*, int> AddContentWithCrossProcessChaining;
    }
}
