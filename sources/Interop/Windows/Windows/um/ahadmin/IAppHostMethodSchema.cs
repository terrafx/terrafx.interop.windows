// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostMethodSchema.xml' path='doc/member[@name="IAppHostMethodSchema"]/*' />
[Guid("2D9915FB-9D42-4328-B782-1B46819FAB9E")]
[NativeTypeName("struct IAppHostMethodSchema : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMethodSchema : IAppHostMethodSchema.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostMethodSchema);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodSchema*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostMethodSchema*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodSchema*, uint>)(lpVtbl[1]))((IAppHostMethodSchema*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodSchema*, uint>)(lpVtbl[2]))((IAppHostMethodSchema*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostMethodSchema.xml' path='doc/member[@name="IAppHostMethodSchema.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodSchema*, char**, int>)(lpVtbl[3]))((IAppHostMethodSchema*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IAppHostMethodSchema.xml' path='doc/member[@name="IAppHostMethodSchema.get_InputSchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_InputSchema(IAppHostElementSchema** ppInputSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodSchema*, IAppHostElementSchema**, int>)(lpVtbl[4]))((IAppHostMethodSchema*)Unsafe.AsPointer(ref this), ppInputSchema);
    }

    /// <include file='IAppHostMethodSchema.xml' path='doc/member[@name="IAppHostMethodSchema.get_OutputSchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_OutputSchema(IAppHostElementSchema** ppOutputSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodSchema*, IAppHostElementSchema**, int>)(lpVtbl[5]))((IAppHostMethodSchema*)Unsafe.AsPointer(ref this), ppOutputSchema);
    }

    /// <include file='IAppHostMethodSchema.xml' path='doc/member[@name="IAppHostMethodSchema.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostMethodSchema*, char*, VARIANT*, int>)(lpVtbl[6]))((IAppHostMethodSchema*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName);

        [VtblIndex(4)]
        HRESULT get_InputSchema(IAppHostElementSchema** ppInputSchema);

        [VtblIndex(5)]
        HRESULT get_OutputSchema(IAppHostElementSchema** ppOutputSchema);

        [VtblIndex(6)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Name;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElementSchema**, int> get_InputSchema;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElementSchema**, int> get_OutputSchema;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;
    }
}
