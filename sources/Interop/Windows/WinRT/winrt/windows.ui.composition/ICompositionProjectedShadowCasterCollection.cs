// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionProjectedShadowCasterCollection.xml' path='doc/member[@name="ICompositionProjectedShadowCasterCollection"]/*' />
[Guid("D2525C0C-E07F-58A3-AC91-37F73EE91740")]
[NativeTypeName("struct ICompositionProjectedShadowCasterCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionProjectedShadowCasterCollection : ICompositionProjectedShadowCasterCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionProjectedShadowCasterCollection);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, uint>)(lpVtbl[1]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, uint>)(lpVtbl[2]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, HSTRING*, int>)(lpVtbl[4]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionProjectedShadowCasterCollection.xml' path='doc/member[@name="ICompositionProjectedShadowCasterCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Count([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, int*, int>)(lpVtbl[6]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadowCasterCollection.xml' path='doc/member[@name="ICompositionProjectedShadowCasterCollection.InsertAbove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertAbove([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* newCaster, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* reference)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, ICompositionProjectedShadowCaster*, ICompositionProjectedShadowCaster*, int>)(lpVtbl[7]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), newCaster, reference);
    }

    /// <include file='ICompositionProjectedShadowCasterCollection.xml' path='doc/member[@name="ICompositionProjectedShadowCasterCollection.InsertAtBottom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InsertAtBottom([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* newCaster)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, ICompositionProjectedShadowCaster*, int>)(lpVtbl[8]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), newCaster);
    }

    /// <include file='ICompositionProjectedShadowCasterCollection.xml' path='doc/member[@name="ICompositionProjectedShadowCasterCollection.InsertAtTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InsertAtTop([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* newCaster)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, ICompositionProjectedShadowCaster*, int>)(lpVtbl[9]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), newCaster);
    }

    /// <include file='ICompositionProjectedShadowCasterCollection.xml' path='doc/member[@name="ICompositionProjectedShadowCasterCollection.InsertBelow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InsertBelow([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* newCaster, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* reference)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, ICompositionProjectedShadowCaster*, ICompositionProjectedShadowCaster*, int>)(lpVtbl[10]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), newCaster, reference);
    }

    /// <include file='ICompositionProjectedShadowCasterCollection.xml' path='doc/member[@name="ICompositionProjectedShadowCasterCollection.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* caster)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, ICompositionProjectedShadowCaster*, int>)(lpVtbl[11]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this), caster);
    }

    /// <include file='ICompositionProjectedShadowCasterCollection.xml' path='doc/member[@name="ICompositionProjectedShadowCasterCollection.RemoveAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveAll()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowCasterCollection*, int>)(lpVtbl[12]))((ICompositionProjectedShadowCasterCollection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Count([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT InsertAbove([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* newCaster, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* reference);

        [VtblIndex(8)]
        HRESULT InsertAtBottom([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* newCaster);

        [VtblIndex(9)]
        HRESULT InsertAtTop([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* newCaster);

        [VtblIndex(10)]
        HRESULT InsertBelow([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* newCaster, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* reference);

        [VtblIndex(11)]
        HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *")] ICompositionProjectedShadowCaster* caster);

        [VtblIndex(12)]
        HRESULT RemoveAll();
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *, ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowCaster*, ICompositionProjectedShadowCaster*, int> InsertAbove;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowCaster*, int> InsertAtBottom;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowCaster*, int> InsertAtTop;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *, ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowCaster*, ICompositionProjectedShadowCaster*, int> InsertBelow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCaster *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowCaster*, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveAll;
    }
}
