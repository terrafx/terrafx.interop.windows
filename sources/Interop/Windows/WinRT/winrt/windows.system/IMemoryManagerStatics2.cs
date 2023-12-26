// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMemoryManagerStatics2.xml' path='doc/member[@name="IMemoryManagerStatics2"]/*' />
[Guid("6EEE351F-6D62-423F-9479-B01F9C9F7669")]
[NativeTypeName("struct IMemoryManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMemoryManagerStatics2 : IMemoryManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMemoryManagerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics2*, uint>)(lpVtbl[1]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics2*, uint>)(lpVtbl[2]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMemoryManagerStatics2.xml' path='doc/member[@name="IMemoryManagerStatics2.GetAppMemoryReport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAppMemoryReport([NativeTypeName("ABI::Windows::System::IAppMemoryReport **")] IAppMemoryReport** memoryReport)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics2*, IAppMemoryReport**, int>)(lpVtbl[6]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), memoryReport);
    }

    /// <include file='IMemoryManagerStatics2.xml' path='doc/member[@name="IMemoryManagerStatics2.GetProcessMemoryReport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetProcessMemoryReport([NativeTypeName("ABI::Windows::System::IProcessMemoryReport **")] IProcessMemoryReport** memoryReport)
    {
        return ((delegate* unmanaged[MemberFunction]<IMemoryManagerStatics2*, IProcessMemoryReport**, int>)(lpVtbl[7]))((IMemoryManagerStatics2*)Unsafe.AsPointer(ref this), memoryReport);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAppMemoryReport([NativeTypeName("ABI::Windows::System::IAppMemoryReport **")] IAppMemoryReport** memoryReport);

        [VtblIndex(7)]
        HRESULT GetProcessMemoryReport([NativeTypeName("ABI::Windows::System::IProcessMemoryReport **")] IProcessMemoryReport** memoryReport);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IAppMemoryReport **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppMemoryReport**, int> GetAppMemoryReport;

        [NativeTypeName("HRESULT (ABI::Windows::System::IProcessMemoryReport **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProcessMemoryReport**, int> GetProcessMemoryReport;
    }
}
