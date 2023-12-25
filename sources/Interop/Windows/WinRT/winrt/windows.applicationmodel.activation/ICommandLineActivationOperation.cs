// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICommandLineActivationOperation.xml' path='doc/member[@name="ICommandLineActivationOperation"]/*' />
[Guid("994B2841-C59E-4F69-BCFD-B61ED4E622EB")]
[NativeTypeName("struct ICommandLineActivationOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICommandLineActivationOperation : ICommandLineActivationOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICommandLineActivationOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, Guid*, void**, int>)(lpVtbl[0]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, uint>)(lpVtbl[1]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, uint>)(lpVtbl[2]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, uint*, Guid**, int>)(lpVtbl[3]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, HSTRING*, int>)(lpVtbl[4]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, TrustLevel*, int>)(lpVtbl[5]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICommandLineActivationOperation.xml' path='doc/member[@name="ICommandLineActivationOperation.get_Arguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Arguments(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, HSTRING*, int>)(lpVtbl[6]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICommandLineActivationOperation.xml' path='doc/member[@name="ICommandLineActivationOperation.get_CurrentDirectoryPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CurrentDirectoryPath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, HSTRING*, int>)(lpVtbl[7]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICommandLineActivationOperation.xml' path='doc/member[@name="ICommandLineActivationOperation.put_ExitCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ExitCode([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, int, int>)(lpVtbl[8]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICommandLineActivationOperation.xml' path='doc/member[@name="ICommandLineActivationOperation.get_ExitCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ExitCode([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, int*, int>)(lpVtbl[9]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICommandLineActivationOperation.xml' path='doc/member[@name="ICommandLineActivationOperation.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICommandLineActivationOperation*, IDeferral**, int>)(lpVtbl[10]))((ICommandLineActivationOperation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Arguments(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_CurrentDirectoryPath(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_ExitCode([NativeTypeName("INT32")] int value);

        [VtblIndex(9)]
        HRESULT get_ExitCode([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Arguments;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CurrentDirectoryPath;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_ExitCode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ExitCode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
