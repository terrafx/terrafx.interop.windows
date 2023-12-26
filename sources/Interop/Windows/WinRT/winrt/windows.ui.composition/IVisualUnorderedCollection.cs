// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVisualUnorderedCollection.xml' path='doc/member[@name="IVisualUnorderedCollection"]/*' />
[Guid("338FAA70-54C8-40A7-8029-C9CEEB0AA250")]
[NativeTypeName("struct IVisualUnorderedCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVisualUnorderedCollection : IVisualUnorderedCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualUnorderedCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, Guid*, void**, int>)(lpVtbl[0]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, uint>)(lpVtbl[1]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, uint>)(lpVtbl[2]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, uint*, Guid**, int>)(lpVtbl[3]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, HSTRING*, int>)(lpVtbl[4]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, TrustLevel*, int>)(lpVtbl[5]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVisualUnorderedCollection.xml' path='doc/member[@name="IVisualUnorderedCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Count([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, int*, int>)(lpVtbl[6]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisualUnorderedCollection.xml' path='doc/member[@name="IVisualUnorderedCollection.Add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Add([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newVisual)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, IVisual*, int>)(lpVtbl[7]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this), newVisual);
    }

    /// <include file='IVisualUnorderedCollection.xml' path='doc/member[@name="IVisualUnorderedCollection.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* visual)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, IVisual*, int>)(lpVtbl[8]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this), visual);
    }

    /// <include file='IVisualUnorderedCollection.xml' path='doc/member[@name="IVisualUnorderedCollection.RemoveAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAll()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualUnorderedCollection*, int>)(lpVtbl[9]))((IVisualUnorderedCollection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Count([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT Add([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newVisual);

        [VtblIndex(8)]
        HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* visual);

        [VtblIndex(9)]
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> Add;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveAll;
    }
}
