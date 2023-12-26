// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionProjectedShadowReceiverUnorderedCollection.xml' path='doc/member[@name="ICompositionProjectedShadowReceiverUnorderedCollection"]/*' />
[Guid("02B3E3B7-27D2-599F-AC4B-AB787CDDE6FD")]
[NativeTypeName("struct ICompositionProjectedShadowReceiverUnorderedCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionProjectedShadowReceiverUnorderedCollection : ICompositionProjectedShadowReceiverUnorderedCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionProjectedShadowReceiverUnorderedCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, uint>)(lpVtbl[1]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, uint>)(lpVtbl[2]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, HSTRING*, int>)(lpVtbl[4]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionProjectedShadowReceiverUnorderedCollection.xml' path='doc/member[@name="ICompositionProjectedShadowReceiverUnorderedCollection.Add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Add([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver *")] ICompositionProjectedShadowReceiver* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, ICompositionProjectedShadowReceiver*, int>)(lpVtbl[6]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadowReceiverUnorderedCollection.xml' path='doc/member[@name="ICompositionProjectedShadowReceiverUnorderedCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Count([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, int*, int>)(lpVtbl[7]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadowReceiverUnorderedCollection.xml' path='doc/member[@name="ICompositionProjectedShadowReceiverUnorderedCollection.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver *")] ICompositionProjectedShadowReceiver* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, ICompositionProjectedShadowReceiver*, int>)(lpVtbl[8]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadowReceiverUnorderedCollection.xml' path='doc/member[@name="ICompositionProjectedShadowReceiverUnorderedCollection.RemoveAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAll()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadowReceiverUnorderedCollection*, int>)(lpVtbl[9]))((ICompositionProjectedShadowReceiverUnorderedCollection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Add([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver *")] ICompositionProjectedShadowReceiver* value);

        [VtblIndex(7)]
        HRESULT get_Count([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver *")] ICompositionProjectedShadowReceiver* value);

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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowReceiver*, int> Add;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiver *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowReceiver*, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveAll;
    }
}
