// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFrameworkView.xml' path='doc/member[@name="IFrameworkView"]/*' />
[Guid("FAAB5CD0-8924-45AC-AD0F-A08FAE5D0324")]
[NativeTypeName("struct IFrameworkView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameworkView : IFrameworkView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFrameworkView);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, Guid*, void**, int>)(lpVtbl[0]))((IFrameworkView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, uint>)(lpVtbl[1]))((IFrameworkView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, uint>)(lpVtbl[2]))((IFrameworkView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, uint*, Guid**, int>)(lpVtbl[3]))((IFrameworkView*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, HSTRING*, int>)(lpVtbl[4]))((IFrameworkView*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, TrustLevel*, int>)(lpVtbl[5]))((IFrameworkView*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFrameworkView.xml' path='doc/member[@name="IFrameworkView.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Initialize([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView *")] ICoreApplicationView* applicationView)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, ICoreApplicationView*, int>)(lpVtbl[6]))((IFrameworkView*)Unsafe.AsPointer(ref this), applicationView);
    }

    /// <include file='IFrameworkView.xml' path='doc/member[@name="IFrameworkView.SetWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetWindow([NativeTypeName("ABI::Windows::UI::Core::ICoreWindow *")] ICoreWindow* window)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, ICoreWindow*, int>)(lpVtbl[7]))((IFrameworkView*)Unsafe.AsPointer(ref this), window);
    }

    /// <include file='IFrameworkView.xml' path='doc/member[@name="IFrameworkView.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Load(HSTRING entryPoint)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, HSTRING, int>)(lpVtbl[8]))((IFrameworkView*)Unsafe.AsPointer(ref this), entryPoint);
    }

    /// <include file='IFrameworkView.xml' path='doc/member[@name="IFrameworkView.Run"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Run()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, int>)(lpVtbl[9]))((IFrameworkView*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFrameworkView.xml' path='doc/member[@name="IFrameworkView.Uninitialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Uninitialize()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameworkView*, int>)(lpVtbl[10]))((IFrameworkView*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Initialize([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView *")] ICoreApplicationView* applicationView);

        [VtblIndex(7)]
        HRESULT SetWindow([NativeTypeName("ABI::Windows::UI::Core::ICoreWindow *")] ICoreWindow* window);

        [VtblIndex(8)]
        HRESULT Load(HSTRING entryPoint);

        [VtblIndex(9)]
        HRESULT Run();

        [VtblIndex(10)]
        HRESULT Uninitialize();
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Core::ICoreApplicationView *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreApplicationView*, int> Initialize;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreWindow *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreWindow*, int> SetWindow;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> Load;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Run;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Uninitialize;
    }
}
