// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostConfigLocationCollection.xml' path='doc/member[@name="IAppHostConfigLocationCollection"]/*' />
[Guid("832A32F7-B3EA-4B8C-B260-9A2923001184")]
[NativeTypeName("struct IAppHostConfigLocationCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConfigLocationCollection : IAppHostConfigLocationCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostConfigLocationCollection);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocationCollection*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostConfigLocationCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocationCollection*, uint>)(lpVtbl[1]))((IAppHostConfigLocationCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocationCollection*, uint>)(lpVtbl[2]))((IAppHostConfigLocationCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostConfigLocationCollection.xml' path='doc/member[@name="IAppHostConfigLocationCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocationCollection*, uint*, int>)(lpVtbl[3]))((IAppHostConfigLocationCollection*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IAppHostConfigLocationCollection.xml' path='doc/member[@name="IAppHostConfigLocationCollection.get_Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT varIndex, IAppHostConfigLocation** ppLocation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocationCollection*, VARIANT, IAppHostConfigLocation**, int>)(lpVtbl[4]))((IAppHostConfigLocationCollection*)Unsafe.AsPointer(ref this), varIndex, ppLocation);
    }

    /// <include file='IAppHostConfigLocationCollection.xml' path='doc/member[@name="IAppHostConfigLocationCollection.AddLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddLocation([NativeTypeName("BSTR")] char* bstrLocationPath, IAppHostConfigLocation** ppNewLocation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocationCollection*, char*, IAppHostConfigLocation**, int>)(lpVtbl[5]))((IAppHostConfigLocationCollection*)Unsafe.AsPointer(ref this), bstrLocationPath, ppNewLocation);
    }

    /// <include file='IAppHostConfigLocationCollection.xml' path='doc/member[@name="IAppHostConfigLocationCollection.DeleteLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteLocation(VARIANT cIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocationCollection*, VARIANT, int>)(lpVtbl[6]))((IAppHostConfigLocationCollection*)Unsafe.AsPointer(ref this), cIndex);
    }

    /// <include file='IAppHostConfigLocationCollection.xml' path='doc/member[@name="IAppHostConfigLocationCollection.RenameLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RenameLocation(VARIANT varIndex, [NativeTypeName("BSTR")] char* bstrLocationPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConfigLocationCollection*, VARIANT, char*, int>)(lpVtbl[7]))((IAppHostConfigLocationCollection*)Unsafe.AsPointer(ref this), varIndex, bstrLocationPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT varIndex, IAppHostConfigLocation** ppLocation);

        [VtblIndex(5)]
        HRESULT AddLocation([NativeTypeName("BSTR")] char* bstrLocationPath, IAppHostConfigLocation** ppNewLocation);

        [VtblIndex(6)]
        HRESULT DeleteLocation(VARIANT cIndex);

        [VtblIndex(7)]
        HRESULT RenameLocation(VARIANT varIndex, [NativeTypeName("BSTR")] char* bstrLocationPath);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IAppHostConfigLocation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IAppHostConfigLocation**, int> get_Item;

        [NativeTypeName("HRESULT (BSTR, IAppHostConfigLocation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostConfigLocation**, int> AddLocation;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> DeleteLocation;

        [NativeTypeName("HRESULT (VARIANT, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, char*, int> RenameLocation;
    }
}
