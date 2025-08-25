// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostMethodInstance.xml' path='doc/member[@name="IAppHostMethodInstance"]/*' />
[Guid("B80F3C42-60E0-4AE0-9007-F52852D3DBED")]
[NativeTypeName("struct IAppHostMethodInstance : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMethodInstance : IAppHostMethodInstance.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostMethodInstance);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodInstance*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostMethodInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodInstance*, uint>)(lpVtbl[1]))((IAppHostMethodInstance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodInstance*, uint>)(lpVtbl[2]))((IAppHostMethodInstance*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostMethodInstance.xml' path='doc/member[@name="IAppHostMethodInstance.get_Input"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Input(IAppHostElement** ppInputElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodInstance*, IAppHostElement**, int>)(lpVtbl[3]))((IAppHostMethodInstance*)Unsafe.AsPointer(ref this), ppInputElement);
    }

    /// <include file='IAppHostMethodInstance.xml' path='doc/member[@name="IAppHostMethodInstance.get_Output"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Output(IAppHostElement** ppOutputElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodInstance*, IAppHostElement**, int>)(lpVtbl[4]))((IAppHostMethodInstance*)Unsafe.AsPointer(ref this), ppOutputElement);
    }

    /// <include file='IAppHostMethodInstance.xml' path='doc/member[@name="IAppHostMethodInstance.Execute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Execute()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodInstance*, int>)(lpVtbl[5]))((IAppHostMethodInstance*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostMethodInstance.xml' path='doc/member[@name="IAppHostMethodInstance.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodInstance*, char*, VARIANT*, int>)(lpVtbl[6]))((IAppHostMethodInstance*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <include file='IAppHostMethodInstance.xml' path='doc/member[@name="IAppHostMethodInstance.SetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodInstance*, char*, VARIANT, int>)(lpVtbl[7]))((IAppHostMethodInstance*)Unsafe.AsPointer(ref this), bstrMetadataType, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Input(IAppHostElement** ppInputElement);

        [VtblIndex(4)]
        HRESULT get_Output(IAppHostElement** ppOutputElement);

        [VtblIndex(5)]
        HRESULT Execute();

        [VtblIndex(6)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(7)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value);
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

        [NativeTypeName("HRESULT (IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElement**, int> get_Input;

        [NativeTypeName("HRESULT (IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElement**, int> get_Output;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Execute;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> SetMetadata;
    }
}
