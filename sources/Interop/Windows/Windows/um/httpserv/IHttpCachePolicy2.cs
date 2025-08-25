// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpCachePolicy2.xml' path='doc/member[@name="IHttpCachePolicy2"]/*' />
[Guid("9F4BA807-050E-4495-AE55-8870F7E9194A")]
[NativeTypeName("struct IHttpCachePolicy2 : IHttpCachePolicy")]
[NativeInheritance("IHttpCachePolicy")]
public unsafe partial struct IHttpCachePolicy2 : IHttpCachePolicy2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpCachePolicy2);

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpCachePolicy.GetKernelCachePolicy" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HTTP_CACHE_POLICY* GetKernelCachePolicy()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, HTTP_CACHE_POLICY*>)(lpVtbl[0]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.SetKernelCacheInvalidatorSet" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void SetKernelCacheInvalidatorSet()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, void>)(lpVtbl[1]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.GetUserCachePolicy" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HTTP_CACHE_POLICY* GetUserCachePolicy()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, HTTP_CACHE_POLICY*>)(lpVtbl[2]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.AppendVaryByHeader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AppendVaryByHeader([NativeTypeName("PCSTR")] sbyte* pszHeader)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, sbyte*, int>)(lpVtbl[3]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this), pszHeader);
    }

    /// <inheritdoc cref="IHttpCachePolicy.GetVaryByHeaders" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("PCSTR")]
    public readonly sbyte* GetVaryByHeaders()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, sbyte*>)(lpVtbl[4]))((IHttpCachePolicy2*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.AppendVaryByQueryString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AppendVaryByQueryString([NativeTypeName("PCSTR")] sbyte* pszParam)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, sbyte*, int>)(lpVtbl[5]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this), pszParam);
    }

    /// <inheritdoc cref="IHttpCachePolicy.GetVaryByQueryStrings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("PCSTR")]
    public readonly sbyte* GetVaryByQueryStrings()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, sbyte*>)(lpVtbl[6]))((IHttpCachePolicy2*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.SetVaryByValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetVaryByValue([NativeTypeName("PCSTR")] sbyte* pszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, sbyte*, int>)(lpVtbl[7]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this), pszValue);
    }

    /// <inheritdoc cref="IHttpCachePolicy.GetVaryByValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("PCSTR")]
    public readonly sbyte* GetVaryByValue()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, sbyte*>)(lpVtbl[8]))((IHttpCachePolicy2*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.IsUserCacheEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public readonly BOOL IsUserCacheEnabled()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, int>)(lpVtbl[9]))((IHttpCachePolicy2*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.DisableUserCache" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void DisableUserCache()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, void>)(lpVtbl[10]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.IsCached" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public readonly BOOL IsCached()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, int>)(lpVtbl[11]))((IHttpCachePolicy2*)Unsafe.AsPointer(in this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.SetIsCached" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void SetIsCached()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, void>)(lpVtbl[12]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpCachePolicy.GetKernelCacheInvalidatorSet" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public readonly BOOL GetKernelCacheInvalidatorSet()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, int>)(lpVtbl[13]))((IHttpCachePolicy2*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpCachePolicy2.xml' path='doc/member[@name="IHttpCachePolicy2.IsForceUpdateSet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public readonly BOOL IsForceUpdateSet()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, int>)(lpVtbl[14]))((IHttpCachePolicy2*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpCachePolicy2.xml' path='doc/member[@name="IHttpCachePolicy2.SetForceUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void SetForceUpdate()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy2*, void>)(lpVtbl[15]))((IHttpCachePolicy2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IHttpCachePolicy.Interface
    {
        [VtblIndex(14)]
        BOOL IsForceUpdateSet();

        [VtblIndex(15)]
        void SetForceUpdate();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HTTP_CACHE_POLICY *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_CACHE_POLICY*> GetKernelCachePolicy;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SetKernelCacheInvalidatorSet;

        [NativeTypeName("HTTP_CACHE_POLICY *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_CACHE_POLICY*> GetUserCachePolicy;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> AppendVaryByHeader;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*> GetVaryByHeaders;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> AppendVaryByQueryString;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*> GetVaryByQueryStrings;

        [NativeTypeName("HRESULT (PCSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, int> SetVaryByValue;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*> GetVaryByValue;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsUserCacheEnabled;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DisableUserCache;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsCached;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SetIsCached;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetKernelCacheInvalidatorSet;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsForceUpdateSet;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SetForceUpdate;
    }
}
