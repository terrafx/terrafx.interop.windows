// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostElementSchemaCollection.xml' path='doc/member[@name="IAppHostElementSchemaCollection"]/*' />
[Guid("0344CDDA-151E-4CBF-82DA-66AE61E97754")]
[NativeTypeName("struct IAppHostElementSchemaCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostElementSchemaCollection : IAppHostElementSchemaCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostElementSchemaCollection);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchemaCollection*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostElementSchemaCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchemaCollection*, uint>)(lpVtbl[1]))((IAppHostElementSchemaCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchemaCollection*, uint>)(lpVtbl[2]))((IAppHostElementSchemaCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostElementSchemaCollection.xml' path='doc/member[@name="IAppHostElementSchemaCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchemaCollection*, uint*, int>)(lpVtbl[3]))((IAppHostElementSchemaCollection*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IAppHostElementSchemaCollection.xml' path='doc/member[@name="IAppHostElementSchemaCollection.get_Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT cIndex, IAppHostElementSchema** ppElementSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchemaCollection*, VARIANT, IAppHostElementSchema**, int>)(lpVtbl[4]))((IAppHostElementSchemaCollection*)Unsafe.AsPointer(ref this), cIndex, ppElementSchema);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT cIndex, IAppHostElementSchema** ppElementSchema);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IAppHostElementSchema**, int> get_Item;
    }
}
