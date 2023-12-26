// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths"]/*' />
[Guid("E32ABF70-D8FA-45EC-A942-D2E26FB60BA5")]
[NativeTypeName("struct ISystemDataPaths : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemDataPaths : ISystemDataPaths.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemDataPaths));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, Guid*, void**, int>)(lpVtbl[0]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, uint>)(lpVtbl[1]))((ISystemDataPaths*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, uint>)(lpVtbl[2]))((ISystemDataPaths*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[4]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, TrustLevel*, int>)(lpVtbl[5]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_Fonts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Fonts(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[6]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_ProgramData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProgramData(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[7]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_Public"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Public(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[8]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_PublicDesktop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PublicDesktop(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[9]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_PublicDocuments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PublicDocuments(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[10]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_PublicDownloads"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PublicDownloads(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[11]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_PublicMusic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PublicMusic(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[12]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_PublicPictures"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PublicPictures(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[13]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_PublicVideos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PublicVideos(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[14]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_System"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_System(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[15]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_SystemHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SystemHost(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[16]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_SystemX86"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SystemX86(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[17]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_SystemX64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SystemX64(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[18]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_SystemArm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_SystemArm(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[19]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_UserProfiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_UserProfiles(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[20]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDataPaths.xml' path='doc/member[@name="ISystemDataPaths.get_Windows"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Windows(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDataPaths*, HSTRING*, int>)(lpVtbl[21]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Fonts(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ProgramData(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Public(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_PublicDesktop(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_PublicDocuments(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_PublicDownloads(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_PublicMusic(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_PublicPictures(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_PublicVideos(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_System(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_SystemHost(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_SystemX86(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_SystemX64(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_SystemArm(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_UserProfiles(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_Windows(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Fonts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ProgramData;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Public;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PublicDesktop;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PublicDocuments;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PublicDownloads;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PublicMusic;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PublicPictures;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PublicVideos;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_System;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SystemHost;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SystemX86;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SystemX64;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SystemArm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserProfiles;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Windows;
    }
}
