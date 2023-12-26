// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVisualCollection.xml' path='doc/member[@name="IVisualCollection"]/*' />
[Guid("8B745505-FD3E-4A98-84A8-E949468C6BCB")]
[NativeTypeName("struct IVisualCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVisualCollection : IVisualCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, Guid*, void**, int>)(lpVtbl[0]))((IVisualCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, uint>)(lpVtbl[1]))((IVisualCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, uint>)(lpVtbl[2]))((IVisualCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, uint*, Guid**, int>)(lpVtbl[3]))((IVisualCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, HSTRING*, int>)(lpVtbl[4]))((IVisualCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, TrustLevel*, int>)(lpVtbl[5]))((IVisualCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVisualCollection.xml' path='doc/member[@name="IVisualCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Count([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, int*, int>)(lpVtbl[6]))((IVisualCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVisualCollection.xml' path='doc/member[@name="IVisualCollection.InsertAbove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertAbove([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newChild, [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* sibling)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, IVisual*, IVisual*, int>)(lpVtbl[7]))((IVisualCollection*)Unsafe.AsPointer(ref this), newChild, sibling);
    }

    /// <include file='IVisualCollection.xml' path='doc/member[@name="IVisualCollection.InsertAtBottom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InsertAtBottom([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newChild)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, IVisual*, int>)(lpVtbl[8]))((IVisualCollection*)Unsafe.AsPointer(ref this), newChild);
    }

    /// <include file='IVisualCollection.xml' path='doc/member[@name="IVisualCollection.InsertAtTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InsertAtTop([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newChild)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, IVisual*, int>)(lpVtbl[9]))((IVisualCollection*)Unsafe.AsPointer(ref this), newChild);
    }

    /// <include file='IVisualCollection.xml' path='doc/member[@name="IVisualCollection.InsertBelow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InsertBelow([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newChild, [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* sibling)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, IVisual*, IVisual*, int>)(lpVtbl[10]))((IVisualCollection*)Unsafe.AsPointer(ref this), newChild, sibling);
    }

    /// <include file='IVisualCollection.xml' path='doc/member[@name="IVisualCollection.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* child)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, IVisual*, int>)(lpVtbl[11]))((IVisualCollection*)Unsafe.AsPointer(ref this), child);
    }

    /// <include file='IVisualCollection.xml' path='doc/member[@name="IVisualCollection.RemoveAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveAll()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualCollection*, int>)(lpVtbl[12]))((IVisualCollection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Count([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT InsertAbove([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newChild, [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* sibling);

        [VtblIndex(8)]
        HRESULT InsertAtBottom([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newChild);

        [VtblIndex(9)]
        HRESULT InsertAtTop([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newChild);

        [VtblIndex(10)]
        HRESULT InsertBelow([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* newChild, [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* sibling);

        [VtblIndex(11)]
        HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual* child);

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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, IVisual*, int> InsertAbove;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> InsertAtBottom;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> InsertAtTop;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, IVisual*, int> InsertBelow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisual*, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveAll;
    }
}
