// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IRegTreeItem.xml' path='doc/member[@name="IRegTreeItem"]/*' />
[Guid("A9521922-0812-4D44-9EC3-7FD38C726F3D")]
[NativeTypeName("struct IRegTreeItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRegTreeItem : IRegTreeItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRegTreeItem));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegTreeItem*, Guid*, void**, int>)(lpVtbl[0]))((IRegTreeItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRegTreeItem*, uint>)(lpVtbl[1]))((IRegTreeItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRegTreeItem*, uint>)(lpVtbl[2]))((IRegTreeItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRegTreeItem.xml' path='doc/member[@name="IRegTreeItem.GetCheckState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCheckState(BOOL* pbCheck)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegTreeItem*, BOOL*, int>)(lpVtbl[3]))((IRegTreeItem*)Unsafe.AsPointer(ref this), pbCheck);
    }

    /// <include file='IRegTreeItem.xml' path='doc/member[@name="IRegTreeItem.SetCheckState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCheckState(BOOL bCheck)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegTreeItem*, BOOL, int>)(lpVtbl[4]))((IRegTreeItem*)Unsafe.AsPointer(ref this), bCheck);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCheckState(BOOL* pbCheck);

        [VtblIndex(4)]
        HRESULT SetCheckState(BOOL bCheck);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> GetCheckState;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> SetCheckState;
    }
}
