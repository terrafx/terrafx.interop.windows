// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFTimedTextFormattedText.xml' path='doc/member[@name="IMFTimedTextFormattedText"]/*' />
[Guid("E13AF3C1-4D47-4354-B1F5-E83AE0ECAE60")]
[NativeTypeName("struct IMFTimedTextFormattedText : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextFormattedText : IMFTimedTextFormattedText.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextFormattedText));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedTextFormattedText*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedTextFormattedText*, uint>)(lpVtbl[1]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedTextFormattedText*, uint>)(lpVtbl[2]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextFormattedText.xml' path='doc/member[@name="IMFTimedTextFormattedText.GetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetText([NativeTypeName("LPWSTR *")] char** text)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedTextFormattedText*, char**, int>)(lpVtbl[3]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this), text);
    }

    /// <include file='IMFTimedTextFormattedText.xml' path='doc/member[@name="IMFTimedTextFormattedText.GetSubformattingCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("DWORD")]
    public uint GetSubformattingCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedTextFormattedText*, uint>)(lpVtbl[4]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextFormattedText.xml' path='doc/member[@name="IMFTimedTextFormattedText.GetSubformatting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSubformatting([NativeTypeName("DWORD")] uint index, [NativeTypeName("DWORD *")] uint* firstChar, [NativeTypeName("DWORD *")] uint* charLength, IMFTimedTextStyle** style)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)(lpVtbl[5]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this), index, firstChar, charLength, style);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetText([NativeTypeName("LPWSTR *")] char** text);

        [VtblIndex(4)]
        [return: NativeTypeName("DWORD")]
        uint GetSubformattingCount();

        [VtblIndex(5)]
        HRESULT GetSubformatting([NativeTypeName("DWORD")] uint index, [NativeTypeName("DWORD *")] uint* firstChar, [NativeTypeName("DWORD *")] uint* charLength, IMFTimedTextStyle** style);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetText;

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetSubformattingCount;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *, IMFTimedTextStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, IMFTimedTextStyle**, int> GetSubformatting;
    }
}
