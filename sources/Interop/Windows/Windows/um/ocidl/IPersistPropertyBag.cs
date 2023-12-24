// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPersistPropertyBag.xml' path='doc/member[@name="IPersistPropertyBag"]/*' />
[Guid("37D84F60-42CB-11CE-8135-00AA004BB851")]
[NativeTypeName("struct IPersistPropertyBag : IPersist")]
[NativeInheritance("IPersist")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IPersistPropertyBag : IPersistPropertyBag.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistPropertyBag));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistPropertyBag*, uint>)(lpVtbl[1]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistPropertyBag*, uint>)(lpVtbl[2]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistPropertyBag*, Guid*, int>)(lpVtbl[3]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistPropertyBag.xml' path='doc/member[@name="IPersistPropertyBag.InitNew"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitNew()
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistPropertyBag*, int>)(lpVtbl[4]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistPropertyBag.xml' path='doc/member[@name="IPersistPropertyBag.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IPropertyBag* pPropBag, IErrorLog* pErrorLog)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistPropertyBag*, IPropertyBag*, IErrorLog*, int>)(lpVtbl[5]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, pErrorLog);
    }

    /// <include file='IPersistPropertyBag.xml' path='doc/member[@name="IPersistPropertyBag.Save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IPropertyBag* pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistPropertyBag*, IPropertyBag*, BOOL, BOOL, int>)(lpVtbl[6]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT InitNew();

        [VtblIndex(5)]
        HRESULT Load(IPropertyBag* pPropBag, IErrorLog* pErrorLog);

        [VtblIndex(6)]
        HRESULT Save(IPropertyBag* pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties);
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> InitNew;

        [NativeTypeName("HRESULT (IPropertyBag *, IErrorLog *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertyBag*, IErrorLog*, int> Load;

        [NativeTypeName("HRESULT (IPropertyBag *, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertyBag*, BOOL, BOOL, int> Save;
    }
}
