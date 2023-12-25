// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo"]/*' />
[Guid("F219352D-9DE8-4420-9CE2-5EFF8F17376B")]
[NativeTypeName("struct IAppBroadcastTriggerProviderInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastTriggerProviderInfo : IAppBroadcastTriggerProviderInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastTriggerProviderInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint>)(lpVtbl[1]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint>)(lpVtbl[2]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.put_DisplayNameResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_DisplayNameResource(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, HSTRING, int>)(lpVtbl[6]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.get_DisplayNameResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayNameResource(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, HSTRING*, int>)(lpVtbl[7]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.put_LogoResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_LogoResource(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, HSTRING, int>)(lpVtbl[8]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.get_LogoResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LogoResource(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, HSTRING*, int>)(lpVtbl[9]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.put_VideoKeyFrameInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_VideoKeyFrameInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, TimeSpan, int>)(lpVtbl[10]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.get_VideoKeyFrameInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_VideoKeyFrameInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, TimeSpan*, int>)(lpVtbl[11]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.put_MaxVideoBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_MaxVideoBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint, int>)(lpVtbl[12]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.get_MaxVideoBitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MaxVideoBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint*, int>)(lpVtbl[13]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.put_MaxVideoWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_MaxVideoWidth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint, int>)(lpVtbl[14]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.get_MaxVideoWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_MaxVideoWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint*, int>)(lpVtbl[15]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.put_MaxVideoHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_MaxVideoHeight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint, int>)(lpVtbl[16]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastTriggerProviderInfo.xml' path='doc/member[@name="IAppBroadcastTriggerProviderInfo.get_MaxVideoHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_MaxVideoHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastTriggerProviderInfo*, uint*, int>)(lpVtbl[17]))((IAppBroadcastTriggerProviderInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_DisplayNameResource(HSTRING value);

        [VtblIndex(7)]
        HRESULT get_DisplayNameResource(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_LogoResource(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_LogoResource(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_VideoKeyFrameInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(11)]
        HRESULT get_VideoKeyFrameInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(12)]
        HRESULT put_MaxVideoBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_MaxVideoBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_MaxVideoWidth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_MaxVideoWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_MaxVideoHeight([NativeTypeName("UINT32")] uint value);

        [VtblIndex(17)]
        HRESULT get_MaxVideoHeight([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayNameResource;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayNameResource;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_LogoResource;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LogoResource;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_VideoKeyFrameInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_VideoKeyFrameInterval;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_MaxVideoBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxVideoBitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_MaxVideoWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxVideoWidth;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_MaxVideoHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxVideoHeight;
    }
}
