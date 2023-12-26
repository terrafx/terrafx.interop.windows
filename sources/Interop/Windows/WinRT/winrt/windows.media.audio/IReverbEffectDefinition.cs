// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition"]/*' />
[Guid("4606AA89-F563-4D0A-8F6E-F0CDDFF35D84")]
[NativeTypeName("struct IReverbEffectDefinition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IReverbEffectDefinition : IReverbEffectDefinition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReverbEffectDefinition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, Guid*, void**, int>)(lpVtbl[0]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, uint>)(lpVtbl[1]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, uint>)(lpVtbl[2]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, uint*, Guid**, int>)(lpVtbl[3]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, HSTRING*, int>)(lpVtbl[4]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, TrustLevel*, int>)(lpVtbl[5]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_WetDryMix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_WetDryMix(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[6]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_WetDryMix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_WetDryMix(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[7]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_ReflectionsDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ReflectionsDelay([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, uint, int>)(lpVtbl[8]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_ReflectionsDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ReflectionsDelay([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, uint*, int>)(lpVtbl[9]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_ReverbDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ReverbDelay(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[10]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_ReverbDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ReverbDelay(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[11]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_RearDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_RearDelay(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[12]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_RearDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RearDelay(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[13]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_PositionLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_PositionLeft(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[14]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_PositionLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PositionLeft(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[15]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_PositionRight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_PositionRight(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[16]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_PositionRight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PositionRight(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[17]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_PositionMatrixLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_PositionMatrixLeft(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[18]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_PositionMatrixLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_PositionMatrixLeft(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[19]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_PositionMatrixRight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_PositionMatrixRight(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[20]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_PositionMatrixRight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_PositionMatrixRight(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[21]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_EarlyDiffusion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_EarlyDiffusion(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[22]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_EarlyDiffusion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_EarlyDiffusion(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[23]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_LateDiffusion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_LateDiffusion(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[24]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_LateDiffusion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_LateDiffusion(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[25]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_LowEQGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_LowEQGain(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[26]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_LowEQGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_LowEQGain(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[27]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_LowEQCutoff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_LowEQCutoff(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[28]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_LowEQCutoff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_LowEQCutoff(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[29]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_HighEQGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_HighEQGain(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[30]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_HighEQGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_HighEQGain(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[31]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_HighEQCutoff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_HighEQCutoff(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[32]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_HighEQCutoff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_HighEQCutoff(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[33]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_RoomFilterFreq"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_RoomFilterFreq(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[34]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_RoomFilterFreq"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_RoomFilterFreq(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[35]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_RoomFilterMain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_RoomFilterMain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[36]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_RoomFilterMain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_RoomFilterMain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[37]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_RoomFilterHF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_RoomFilterHF(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[38]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_RoomFilterHF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_RoomFilterHF(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[39]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_ReflectionsGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_ReflectionsGain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[40]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_ReflectionsGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_ReflectionsGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[41]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_ReverbGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_ReverbGain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[42]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_ReverbGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_ReverbGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[43]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_DecayTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_DecayTime(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[44]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_DecayTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_DecayTime(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[45]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_Density"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_Density(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[46]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_Density"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_Density(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[47]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_RoomSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_RoomSize(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double, int>)(lpVtbl[48]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_RoomSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_RoomSize(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, double*, int>)(lpVtbl[49]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.put_DisableLateField"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_DisableLateField([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte, int>)(lpVtbl[50]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReverbEffectDefinition.xml' path='doc/member[@name="IReverbEffectDefinition.get_DisableLateField"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_DisableLateField([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReverbEffectDefinition*, byte*, int>)(lpVtbl[51]))((IReverbEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_WetDryMix(double value);

        [VtblIndex(7)]
        HRESULT get_WetDryMix(double* value);

        [VtblIndex(8)]
        HRESULT put_ReflectionsDelay([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_ReflectionsDelay([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_ReverbDelay(byte value);

        [VtblIndex(11)]
        HRESULT get_ReverbDelay(byte* value);

        [VtblIndex(12)]
        HRESULT put_RearDelay(byte value);

        [VtblIndex(13)]
        HRESULT get_RearDelay(byte* value);

        [VtblIndex(14)]
        HRESULT put_PositionLeft(byte value);

        [VtblIndex(15)]
        HRESULT get_PositionLeft(byte* value);

        [VtblIndex(16)]
        HRESULT put_PositionRight(byte value);

        [VtblIndex(17)]
        HRESULT get_PositionRight(byte* value);

        [VtblIndex(18)]
        HRESULT put_PositionMatrixLeft(byte value);

        [VtblIndex(19)]
        HRESULT get_PositionMatrixLeft(byte* value);

        [VtblIndex(20)]
        HRESULT put_PositionMatrixRight(byte value);

        [VtblIndex(21)]
        HRESULT get_PositionMatrixRight(byte* value);

        [VtblIndex(22)]
        HRESULT put_EarlyDiffusion(byte value);

        [VtblIndex(23)]
        HRESULT get_EarlyDiffusion(byte* value);

        [VtblIndex(24)]
        HRESULT put_LateDiffusion(byte value);

        [VtblIndex(25)]
        HRESULT get_LateDiffusion(byte* value);

        [VtblIndex(26)]
        HRESULT put_LowEQGain(byte value);

        [VtblIndex(27)]
        HRESULT get_LowEQGain(byte* value);

        [VtblIndex(28)]
        HRESULT put_LowEQCutoff(byte value);

        [VtblIndex(29)]
        HRESULT get_LowEQCutoff(byte* value);

        [VtblIndex(30)]
        HRESULT put_HighEQGain(byte value);

        [VtblIndex(31)]
        HRESULT get_HighEQGain(byte* value);

        [VtblIndex(32)]
        HRESULT put_HighEQCutoff(byte value);

        [VtblIndex(33)]
        HRESULT get_HighEQCutoff(byte* value);

        [VtblIndex(34)]
        HRESULT put_RoomFilterFreq(double value);

        [VtblIndex(35)]
        HRESULT get_RoomFilterFreq(double* value);

        [VtblIndex(36)]
        HRESULT put_RoomFilterMain(double value);

        [VtblIndex(37)]
        HRESULT get_RoomFilterMain(double* value);

        [VtblIndex(38)]
        HRESULT put_RoomFilterHF(double value);

        [VtblIndex(39)]
        HRESULT get_RoomFilterHF(double* value);

        [VtblIndex(40)]
        HRESULT put_ReflectionsGain(double value);

        [VtblIndex(41)]
        HRESULT get_ReflectionsGain(double* value);

        [VtblIndex(42)]
        HRESULT put_ReverbGain(double value);

        [VtblIndex(43)]
        HRESULT get_ReverbGain(double* value);

        [VtblIndex(44)]
        HRESULT put_DecayTime(double value);

        [VtblIndex(45)]
        HRESULT get_DecayTime(double* value);

        [VtblIndex(46)]
        HRESULT put_Density(double value);

        [VtblIndex(47)]
        HRESULT get_Density(double* value);

        [VtblIndex(48)]
        HRESULT put_RoomSize(double value);

        [VtblIndex(49)]
        HRESULT get_RoomSize(double* value);

        [VtblIndex(50)]
        HRESULT put_DisableLateField([NativeTypeName("boolean")] byte value);

        [VtblIndex(51)]
        HRESULT get_DisableLateField([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_WetDryMix;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_WetDryMix;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ReflectionsDelay;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ReflectionsDelay;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ReverbDelay;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ReverbDelay;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_RearDelay;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_RearDelay;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_PositionLeft;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PositionLeft;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_PositionRight;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PositionRight;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_PositionMatrixLeft;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PositionMatrixLeft;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_PositionMatrixRight;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PositionMatrixRight;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_EarlyDiffusion;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_EarlyDiffusion;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_LateDiffusion;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_LateDiffusion;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_LowEQGain;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_LowEQGain;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_LowEQCutoff;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_LowEQCutoff;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_HighEQGain;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HighEQGain;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_HighEQCutoff;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HighEQCutoff;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_RoomFilterFreq;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RoomFilterFreq;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_RoomFilterMain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RoomFilterMain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_RoomFilterHF;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RoomFilterHF;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_ReflectionsGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_ReflectionsGain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_ReverbGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_ReverbGain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_DecayTime;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_DecayTime;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Density;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Density;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_RoomSize;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RoomSize;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_DisableLateField;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DisableLateField;
    }
}
