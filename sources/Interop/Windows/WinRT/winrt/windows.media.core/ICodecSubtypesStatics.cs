// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics"]/*' />
[Guid("A66AC4F2-888B-4224-8CF6-2A8D4EB02382")]
[NativeTypeName("struct ICodecSubtypesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICodecSubtypesStatics : ICodecSubtypesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICodecSubtypesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, uint>)(lpVtbl[1]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, uint>)(lpVtbl[2]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[4]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatDV25"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoFormatDV25(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[6]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatDV50"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoFormatDV50(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[7]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatDvc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideoFormatDvc(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[8]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatDvh1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VideoFormatDvh1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[9]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatDvhD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoFormatDvhD(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[10]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatDvsd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_VideoFormatDvsd(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[11]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatDvsl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_VideoFormatDvsl(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[12]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatH263"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_VideoFormatH263(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[13]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatH264"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VideoFormatH264(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[14]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatH265"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_VideoFormatH265(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[15]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatH264ES"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_VideoFormatH264ES(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[16]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatHevc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_VideoFormatHevc(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[17]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatHevcES"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_VideoFormatHevcES(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[18]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatM4S2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_VideoFormatM4S2(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[19]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatMjpg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_VideoFormatMjpg(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[20]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatMP43"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_VideoFormatMP43(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[21]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatMP4S"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_VideoFormatMP4S(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[22]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatMP4V"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_VideoFormatMP4V(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[23]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatMpeg2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_VideoFormatMpeg2(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[24]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatVP80"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_VideoFormatVP80(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[25]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatVP90"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_VideoFormatVP90(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[26]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatMpg1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_VideoFormatMpg1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[27]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatMss1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_VideoFormatMss1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[28]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatMss2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_VideoFormatMss2(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[29]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatWmv1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_VideoFormatWmv1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[30]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatWmv2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_VideoFormatWmv2(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[31]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatWmv3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_VideoFormatWmv3(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[32]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormatWvc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_VideoFormatWvc1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[33]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_VideoFormat420O"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_VideoFormat420O(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[34]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatAac"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_AudioFormatAac(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[35]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatAdts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_AudioFormatAdts(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[36]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatAlac"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_AudioFormatAlac(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[37]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatAmrNB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_AudioFormatAmrNB(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[38]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatAmrWB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_AudioFormatAmrWB(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[39]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatAmrWP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_AudioFormatAmrWP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[40]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatDolbyAC3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_AudioFormatDolbyAC3(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[41]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatDolbyAC3Spdif"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_AudioFormatDolbyAC3Spdif(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[42]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatDolbyDDPlus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_AudioFormatDolbyDDPlus(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[43]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatDrm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_AudioFormatDrm(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[44]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatDts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_AudioFormatDts(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[45]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatFlac"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_AudioFormatFlac(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[46]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatFloat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_AudioFormatFloat(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[47]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatMP3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_AudioFormatMP3(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[48]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatMPeg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_AudioFormatMPeg(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[49]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatMsp1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_AudioFormatMsp1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[50]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatOpus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_AudioFormatOpus(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[51]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatPcm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_AudioFormatPcm(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[52]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatWmaSpdif"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_AudioFormatWmaSpdif(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[53]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatWMAudioLossless"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_AudioFormatWMAudioLossless(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[54]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatWMAudioV8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_AudioFormatWMAudioV8(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[55]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICodecSubtypesStatics.xml' path='doc/member[@name="ICodecSubtypesStatics.get_AudioFormatWMAudioV9"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_AudioFormatWMAudioV9(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICodecSubtypesStatics*, HSTRING*, int>)(lpVtbl[56]))((ICodecSubtypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoFormatDV25(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_VideoFormatDV50(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_VideoFormatDvc(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_VideoFormatDvh1(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_VideoFormatDvhD(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_VideoFormatDvsd(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_VideoFormatDvsl(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_VideoFormatH263(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_VideoFormatH264(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_VideoFormatH265(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_VideoFormatH264ES(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_VideoFormatHevc(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_VideoFormatHevcES(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_VideoFormatM4S2(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_VideoFormatMjpg(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_VideoFormatMP43(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_VideoFormatMP4S(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_VideoFormatMP4V(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_VideoFormatMpeg2(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_VideoFormatVP80(HSTRING* value);

        [VtblIndex(26)]
        HRESULT get_VideoFormatVP90(HSTRING* value);

        [VtblIndex(27)]
        HRESULT get_VideoFormatMpg1(HSTRING* value);

        [VtblIndex(28)]
        HRESULT get_VideoFormatMss1(HSTRING* value);

        [VtblIndex(29)]
        HRESULT get_VideoFormatMss2(HSTRING* value);

        [VtblIndex(30)]
        HRESULT get_VideoFormatWmv1(HSTRING* value);

        [VtblIndex(31)]
        HRESULT get_VideoFormatWmv2(HSTRING* value);

        [VtblIndex(32)]
        HRESULT get_VideoFormatWmv3(HSTRING* value);

        [VtblIndex(33)]
        HRESULT get_VideoFormatWvc1(HSTRING* value);

        [VtblIndex(34)]
        HRESULT get_VideoFormat420O(HSTRING* value);

        [VtblIndex(35)]
        HRESULT get_AudioFormatAac(HSTRING* value);

        [VtblIndex(36)]
        HRESULT get_AudioFormatAdts(HSTRING* value);

        [VtblIndex(37)]
        HRESULT get_AudioFormatAlac(HSTRING* value);

        [VtblIndex(38)]
        HRESULT get_AudioFormatAmrNB(HSTRING* value);

        [VtblIndex(39)]
        HRESULT get_AudioFormatAmrWB(HSTRING* value);

        [VtblIndex(40)]
        HRESULT get_AudioFormatAmrWP(HSTRING* value);

        [VtblIndex(41)]
        HRESULT get_AudioFormatDolbyAC3(HSTRING* value);

        [VtblIndex(42)]
        HRESULT get_AudioFormatDolbyAC3Spdif(HSTRING* value);

        [VtblIndex(43)]
        HRESULT get_AudioFormatDolbyDDPlus(HSTRING* value);

        [VtblIndex(44)]
        HRESULT get_AudioFormatDrm(HSTRING* value);

        [VtblIndex(45)]
        HRESULT get_AudioFormatDts(HSTRING* value);

        [VtblIndex(46)]
        HRESULT get_AudioFormatFlac(HSTRING* value);

        [VtblIndex(47)]
        HRESULT get_AudioFormatFloat(HSTRING* value);

        [VtblIndex(48)]
        HRESULT get_AudioFormatMP3(HSTRING* value);

        [VtblIndex(49)]
        HRESULT get_AudioFormatMPeg(HSTRING* value);

        [VtblIndex(50)]
        HRESULT get_AudioFormatMsp1(HSTRING* value);

        [VtblIndex(51)]
        HRESULT get_AudioFormatOpus(HSTRING* value);

        [VtblIndex(52)]
        HRESULT get_AudioFormatPcm(HSTRING* value);

        [VtblIndex(53)]
        HRESULT get_AudioFormatWmaSpdif(HSTRING* value);

        [VtblIndex(54)]
        HRESULT get_AudioFormatWMAudioLossless(HSTRING* value);

        [VtblIndex(55)]
        HRESULT get_AudioFormatWMAudioV8(HSTRING* value);

        [VtblIndex(56)]
        HRESULT get_AudioFormatWMAudioV9(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatDV25;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatDV50;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatDvc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatDvh1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatDvhD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatDvsd;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatDvsl;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatH263;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatH264;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatH265;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatH264ES;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatHevc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatHevcES;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatM4S2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatMjpg;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatMP43;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatMP4S;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatMP4V;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatMpeg2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatVP80;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatVP90;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatMpg1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatMss1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatMss2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatWmv1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatWmv2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatWmv3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormatWvc1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoFormat420O;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatAac;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatAdts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatAlac;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatAmrNB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatAmrWB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatAmrWP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatDolbyAC3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatDolbyAC3Spdif;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatDolbyDDPlus;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatDrm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatDts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatFlac;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatFloat;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatMP3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatMPeg;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatMsp1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatOpus;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatPcm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatWmaSpdif;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatWMAudioLossless;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatWMAudioV8;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioFormatWMAudioV9;
    }
}
