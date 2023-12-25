// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionObject.xml' path='doc/member[@name="ICompositionObject"]/*' />
[Guid("BCB4AD45-7609-4550-934F-16002A68FDED")]
[NativeTypeName("struct ICompositionObject : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionObject : ICompositionObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionObject));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, uint>)(lpVtbl[1]))((ICompositionObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, uint>)(lpVtbl[2]))((ICompositionObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionObject*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, HSTRING*, int>)(lpVtbl[4]))((ICompositionObject*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionObject*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionObject.xml' path='doc/member[@name="ICompositionObject.get_Compositor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Compositor([NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, ICompositor**, int>)(lpVtbl[6]))((ICompositionObject*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionObject.xml' path='doc/member[@name="ICompositionObject.get_Dispatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, ICoreDispatcher**, int>)(lpVtbl[7]))((ICompositionObject*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionObject.xml' path='doc/member[@name="ICompositionObject.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::UI::Composition::ICompositionPropertySet **")] ICompositionPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, ICompositionPropertySet**, int>)(lpVtbl[8]))((ICompositionObject*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionObject.xml' path='doc/member[@name="ICompositionObject.StartAnimation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartAnimation(HSTRING propertyName, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")] ICompositionAnimation* animation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, HSTRING, ICompositionAnimation*, int>)(lpVtbl[9]))((ICompositionObject*)Unsafe.AsPointer(ref this), propertyName, animation);
    }

    /// <include file='ICompositionObject.xml' path='doc/member[@name="ICompositionObject.StopAnimation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopAnimation(HSTRING propertyName)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionObject*, HSTRING, int>)(lpVtbl[10]))((ICompositionObject*)Unsafe.AsPointer(ref this), propertyName);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Compositor([NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor** value);

        [VtblIndex(7)]
        HRESULT get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value);

        [VtblIndex(8)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::UI::Composition::ICompositionPropertySet **")] ICompositionPropertySet** value);

        [VtblIndex(9)]
        HRESULT StartAnimation(HSTRING propertyName, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")] ICompositionAnimation* animation);

        [VtblIndex(10)]
        HRESULT StopAnimation(HSTRING propertyName);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor**, int> get_Compositor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreDispatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreDispatcher**, int> get_Dispatcher;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionPropertySet**, int> get_Properties;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionAnimation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ICompositionAnimation*, int> StartAnimation;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> StopAnimation;
    }
}
