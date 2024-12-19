// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy"]/*' />
[Guid("CB1C40CA-70F2-41A0-ADD2-881F5EF57388")]
public unsafe partial struct IHttpCachePolicy : IHttpCachePolicy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCachePolicy));

    public void** lpVtbl;

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.GetKernelCachePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HTTP_CACHE_POLICY* GetKernelCachePolicy()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, HTTP_CACHE_POLICY*>)(lpVtbl[0]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.SetKernelCacheInvalidatorSet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void SetKernelCacheInvalidatorSet()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, void>)(lpVtbl[1]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.GetUserCachePolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HTTP_CACHE_POLICY* GetUserCachePolicy()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, HTTP_CACHE_POLICY*>)(lpVtbl[2]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.AppendVaryByHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AppendVaryByHeader([NativeTypeName("PCSTR")] sbyte* pszHeader)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, sbyte*, int>)(lpVtbl[3]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this), pszHeader);
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.GetVaryByHeaders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetVaryByHeaders()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, sbyte*>)(lpVtbl[4]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.AppendVaryByQueryString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AppendVaryByQueryString([NativeTypeName("PCSTR")] sbyte* pszParam)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, sbyte*, int>)(lpVtbl[5]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this), pszParam);
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.GetVaryByQueryStrings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetVaryByQueryStrings()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, sbyte*>)(lpVtbl[6]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.SetVaryByValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetVaryByValue([NativeTypeName("PCSTR")] sbyte* pszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, sbyte*, int>)(lpVtbl[7]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this), pszValue);
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.GetVaryByValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetVaryByValue()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, sbyte*>)(lpVtbl[8]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.IsUserCacheEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public BOOL IsUserCacheEnabled()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, int>)(lpVtbl[9]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.DisableUserCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void DisableUserCache()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, void>)(lpVtbl[10]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.IsCached"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public BOOL IsCached()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, int>)(lpVtbl[11]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.SetIsCached"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void SetIsCached()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, void>)(lpVtbl[12]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpCachePolicy.xml' path='doc/member[@name="IHttpCachePolicy.GetKernelCacheInvalidatorSet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public BOOL GetKernelCacheInvalidatorSet()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCachePolicy*, int>)(lpVtbl[13]))((IHttpCachePolicy*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HTTP_CACHE_POLICY* GetKernelCachePolicy();

        [VtblIndex(1)]
        void SetKernelCacheInvalidatorSet();

        [VtblIndex(2)]
        HTTP_CACHE_POLICY* GetUserCachePolicy();

        [VtblIndex(3)]
        HRESULT AppendVaryByHeader([NativeTypeName("PCSTR")] sbyte* pszHeader);

        [VtblIndex(4)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetVaryByHeaders();

        [VtblIndex(5)]
        HRESULT AppendVaryByQueryString([NativeTypeName("PCSTR")] sbyte* pszParam);

        [VtblIndex(6)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetVaryByQueryStrings();

        [VtblIndex(7)]
        HRESULT SetVaryByValue([NativeTypeName("PCSTR")] sbyte* pszValue);

        [VtblIndex(8)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetVaryByValue();

        [VtblIndex(9)]
        BOOL IsUserCacheEnabled();

        [VtblIndex(10)]
        void DisableUserCache();

        [VtblIndex(11)]
        BOOL IsCached();

        [VtblIndex(12)]
        void SetIsCached();

        [VtblIndex(13)]
        BOOL GetKernelCacheInvalidatorSet();
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
    }
}
