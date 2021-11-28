// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("47C01F95-E185-412C-B5C5-4F27DF965AEA")]
[NativeTypeName("struct IFolderBandPriv : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFolderBandPriv : IFolderBandPriv.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFolderBandPriv*, Guid*, void**, int>)(lpVtbl[0]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFolderBandPriv*, uint>)(lpVtbl[1]))((IFolderBandPriv*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFolderBandPriv*, uint>)(lpVtbl[2]))((IFolderBandPriv*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetCascade(BOOL fCascade)
    {
        return ((delegate* unmanaged<IFolderBandPriv*, BOOL, int>)(lpVtbl[3]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), fCascade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAccelerators(BOOL fAccelerators)
    {
        return ((delegate* unmanaged<IFolderBandPriv*, BOOL, int>)(lpVtbl[4]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), fAccelerators);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetNoIcons(BOOL fNoIcons)
    {
        return ((delegate* unmanaged<IFolderBandPriv*, BOOL, int>)(lpVtbl[5]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), fNoIcons);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetNoText(BOOL fNoText)
    {
        return ((delegate* unmanaged<IFolderBandPriv*, BOOL, int>)(lpVtbl[6]))((IFolderBandPriv*)Unsafe.AsPointer(ref this), fNoText);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetCascade(BOOL fCascade);

        [VtblIndex(4)]
        HRESULT SetAccelerators(BOOL fAccelerators);

        [VtblIndex(5)]
        HRESULT SetNoIcons(BOOL fNoIcons);

        [VtblIndex(6)]
        HRESULT SetNoText(BOOL fNoText);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetCascade;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetAccelerators;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetNoIcons;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetNoText;
    }
}
