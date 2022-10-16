// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics"]/*' />
[Guid("CFF52E04-CCA6-4614-A17E-754910C84A99")]
[NativeTypeName("struct IColorsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IColorsStatics : IColorsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IColorsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IColorsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IColorsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IColorsStatics*, uint>)(lpVtbl[1]))((IColorsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IColorsStatics*, uint>)(lpVtbl[2]))((IColorsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IColorsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IColorsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IColorsStatics*, HSTRING*, int>)(lpVtbl[4]))((IColorsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IColorsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IColorsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_AliceBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AliceBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[6]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_AntiqueWhite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AntiqueWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[7]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Aqua"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Aqua([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[8]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Aquamarine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Aquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[9]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Azure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Azure([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[10]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Beige"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Beige([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[11]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Bisque"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Bisque([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[12]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Black"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Black([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[13]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_BlanchedAlmond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_BlanchedAlmond([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[14]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Blue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Blue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[15]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_BlueViolet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_BlueViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[16]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Brown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Brown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[17]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_BurlyWood"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BurlyWood([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[18]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_CadetBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_CadetBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[19]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Chartreuse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Chartreuse([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[20]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Chocolate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Chocolate([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[21]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Coral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Coral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[22]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_CornflowerBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_CornflowerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[23]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Cornsilk"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Cornsilk([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[24]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Crimson"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Crimson([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[25]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Cyan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Cyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[26]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_DarkBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[27]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkCyan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_DarkCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[28]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkGoldenrod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_DarkGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[29]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkGray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_DarkGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[30]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_DarkGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[31]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkKhaki"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_DarkKhaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[32]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkMagenta"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_DarkMagenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[33]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkOliveGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_DarkOliveGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[34]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkOrange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_DarkOrange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[35]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkOrchid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_DarkOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[36]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkRed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_DarkRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[37]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkSalmon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_DarkSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[38]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkSeaGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_DarkSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[39]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkSlateBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_DarkSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[40]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkSlateGray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_DarkSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[41]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkTurquoise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_DarkTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[42]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DarkViolet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_DarkViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[43]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DeepPink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_DeepPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[44]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DeepSkyBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_DeepSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[45]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DimGray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_DimGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[46]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_DodgerBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_DodgerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[47]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Firebrick"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_Firebrick([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[48]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_FloralWhite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_FloralWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[49]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_ForestGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_ForestGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[50]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Fuchsia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_Fuchsia([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[51]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Gainsboro"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_Gainsboro([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[52]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_GhostWhite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_GhostWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[53]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Gold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_Gold([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[54]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Goldenrod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_Goldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[55]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Gray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_Gray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[56]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Green"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_Green([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[57]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_GreenYellow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_GreenYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[58]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Honeydew"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_Honeydew([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[59]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_HotPink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_HotPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[60]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_IndianRed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_IndianRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[61]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Indigo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_Indigo([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[62]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Ivory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_Ivory([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[63]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Khaki"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_Khaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[64]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Lavender"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_Lavender([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[65]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LavenderBlush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_LavenderBlush([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[66]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LawnGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_LawnGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[67]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LemonChiffon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_LemonChiffon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[68]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_LightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[69]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightCoral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_LightCoral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[70]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightCyan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_LightCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[71]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightGoldenrodYellow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_LightGoldenrodYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[72]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT get_LightGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[73]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightGray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_LightGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[74]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightPink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT get_LightPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[75]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightSalmon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_LightSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[76]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightSeaGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT get_LightSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[77]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightSkyBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_LightSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[78]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightSlateGray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT get_LightSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[79]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightSteelBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_LightSteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[80]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LightYellow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_LightYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[81]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Lime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_Lime([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[82]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_LimeGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_LimeGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[83]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Linen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_Linen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[84]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Magenta"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT get_Magenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[85]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Maroon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_Maroon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[86]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumAquamarine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT get_MediumAquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[87]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_MediumBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[88]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumOrchid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT get_MediumOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[89]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumPurple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_MediumPurple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[90]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumSeaGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT get_MediumSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[91]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumSlateBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_MediumSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[92]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumSpringGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT get_MediumSpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[93]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumTurquoise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_MediumTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[94]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MediumVioletRed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT get_MediumVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[95]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MidnightBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_MidnightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[96]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MintCream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_MintCream([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[97]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_MistyRose"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_MistyRose([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[98]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Moccasin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT get_Moccasin([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[99]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_NavajoWhite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_NavajoWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[100]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Navy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT get_Navy([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[101]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_OldLace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_OldLace([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[102]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Olive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_Olive([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[103]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_OliveDrab"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_OliveDrab([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[104]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Orange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT get_Orange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[105]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_OrangeRed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_OrangeRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[106]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Orchid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT get_Orchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[107]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_PaleGoldenrod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_PaleGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[108]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_PaleGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_PaleGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[109]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_PaleTurquoise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT get_PaleTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[110]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_PaleVioletRed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_PaleVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[111]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_PapayaWhip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT get_PapayaWhip([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[112]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_PeachPuff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT get_PeachPuff([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[113]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Peru"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT get_Peru([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[114]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Pink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT get_Pink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[115]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Plum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT get_Plum([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[116]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_PowderBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT get_PowderBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[117]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Purple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT get_Purple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[118]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Red"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT get_Red([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[119]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_RosyBrown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT get_RosyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[120]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_RoyalBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT get_RoyalBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[121]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SaddleBrown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT get_SaddleBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[122]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Salmon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT get_Salmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[123]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SandyBrown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT get_SandyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[124]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SeaGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT get_SeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[125]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SeaShell"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HRESULT get_SeaShell([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[126]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Sienna"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HRESULT get_Sienna([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[127]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Silver"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HRESULT get_Silver([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[128]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SkyBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HRESULT get_SkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[129]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SlateBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HRESULT get_SlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[130]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SlateGray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HRESULT get_SlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[131]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Snow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HRESULT get_Snow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[132]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SpringGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HRESULT get_SpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[133]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_SteelBlue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(134)]
    public HRESULT get_SteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[134]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Tan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(135)]
    public HRESULT get_Tan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[135]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Teal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(136)]
    public HRESULT get_Teal([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[136]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Thistle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(137)]
    public HRESULT get_Thistle([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[137]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Tomato"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(138)]
    public HRESULT get_Tomato([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[138]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Transparent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(139)]
    public HRESULT get_Transparent([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[139]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Turquoise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(140)]
    public HRESULT get_Turquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[140]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Violet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(141)]
    public HRESULT get_Violet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[141]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Wheat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(142)]
    public HRESULT get_Wheat([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[142]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_White"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(143)]
    public HRESULT get_White([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[143]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_WhiteSmoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(144)]
    public HRESULT get_WhiteSmoke([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[144]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_Yellow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(145)]
    public HRESULT get_Yellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[145]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IColorsStatics.xml' path='doc/member[@name="IColorsStatics.get_YellowGreen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(146)]
    public HRESULT get_YellowGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[146]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AliceBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(7)]
        HRESULT get_AntiqueWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(8)]
        HRESULT get_Aqua([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT get_Aquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(10)]
        HRESULT get_Azure([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(11)]
        HRESULT get_Beige([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(12)]
        HRESULT get_Bisque([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(13)]
        HRESULT get_Black([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(14)]
        HRESULT get_BlanchedAlmond([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(15)]
        HRESULT get_Blue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(16)]
        HRESULT get_BlueViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(17)]
        HRESULT get_Brown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(18)]
        HRESULT get_BurlyWood([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(19)]
        HRESULT get_CadetBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(20)]
        HRESULT get_Chartreuse([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(21)]
        HRESULT get_Chocolate([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(22)]
        HRESULT get_Coral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(23)]
        HRESULT get_CornflowerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(24)]
        HRESULT get_Cornsilk([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(25)]
        HRESULT get_Crimson([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(26)]
        HRESULT get_Cyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(27)]
        HRESULT get_DarkBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(28)]
        HRESULT get_DarkCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(29)]
        HRESULT get_DarkGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(30)]
        HRESULT get_DarkGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(31)]
        HRESULT get_DarkGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(32)]
        HRESULT get_DarkKhaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(33)]
        HRESULT get_DarkMagenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(34)]
        HRESULT get_DarkOliveGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(35)]
        HRESULT get_DarkOrange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(36)]
        HRESULT get_DarkOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(37)]
        HRESULT get_DarkRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(38)]
        HRESULT get_DarkSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(39)]
        HRESULT get_DarkSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(40)]
        HRESULT get_DarkSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(41)]
        HRESULT get_DarkSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(42)]
        HRESULT get_DarkTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(43)]
        HRESULT get_DarkViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(44)]
        HRESULT get_DeepPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(45)]
        HRESULT get_DeepSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(46)]
        HRESULT get_DimGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(47)]
        HRESULT get_DodgerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(48)]
        HRESULT get_Firebrick([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(49)]
        HRESULT get_FloralWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(50)]
        HRESULT get_ForestGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(51)]
        HRESULT get_Fuchsia([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(52)]
        HRESULT get_Gainsboro([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(53)]
        HRESULT get_GhostWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(54)]
        HRESULT get_Gold([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(55)]
        HRESULT get_Goldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(56)]
        HRESULT get_Gray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(57)]
        HRESULT get_Green([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(58)]
        HRESULT get_GreenYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(59)]
        HRESULT get_Honeydew([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(60)]
        HRESULT get_HotPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(61)]
        HRESULT get_IndianRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(62)]
        HRESULT get_Indigo([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(63)]
        HRESULT get_Ivory([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(64)]
        HRESULT get_Khaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(65)]
        HRESULT get_Lavender([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(66)]
        HRESULT get_LavenderBlush([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(67)]
        HRESULT get_LawnGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(68)]
        HRESULT get_LemonChiffon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(69)]
        HRESULT get_LightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(70)]
        HRESULT get_LightCoral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(71)]
        HRESULT get_LightCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(72)]
        HRESULT get_LightGoldenrodYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(73)]
        HRESULT get_LightGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(74)]
        HRESULT get_LightGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(75)]
        HRESULT get_LightPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(76)]
        HRESULT get_LightSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(77)]
        HRESULT get_LightSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(78)]
        HRESULT get_LightSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(79)]
        HRESULT get_LightSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(80)]
        HRESULT get_LightSteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(81)]
        HRESULT get_LightYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(82)]
        HRESULT get_Lime([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(83)]
        HRESULT get_LimeGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(84)]
        HRESULT get_Linen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(85)]
        HRESULT get_Magenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(86)]
        HRESULT get_Maroon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(87)]
        HRESULT get_MediumAquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(88)]
        HRESULT get_MediumBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(89)]
        HRESULT get_MediumOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(90)]
        HRESULT get_MediumPurple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(91)]
        HRESULT get_MediumSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(92)]
        HRESULT get_MediumSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(93)]
        HRESULT get_MediumSpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(94)]
        HRESULT get_MediumTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(95)]
        HRESULT get_MediumVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(96)]
        HRESULT get_MidnightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(97)]
        HRESULT get_MintCream([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(98)]
        HRESULT get_MistyRose([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(99)]
        HRESULT get_Moccasin([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(100)]
        HRESULT get_NavajoWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(101)]
        HRESULT get_Navy([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(102)]
        HRESULT get_OldLace([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(103)]
        HRESULT get_Olive([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(104)]
        HRESULT get_OliveDrab([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(105)]
        HRESULT get_Orange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(106)]
        HRESULT get_OrangeRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(107)]
        HRESULT get_Orchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(108)]
        HRESULT get_PaleGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(109)]
        HRESULT get_PaleGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(110)]
        HRESULT get_PaleTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(111)]
        HRESULT get_PaleVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(112)]
        HRESULT get_PapayaWhip([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(113)]
        HRESULT get_PeachPuff([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(114)]
        HRESULT get_Peru([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(115)]
        HRESULT get_Pink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(116)]
        HRESULT get_Plum([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(117)]
        HRESULT get_PowderBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(118)]
        HRESULT get_Purple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(119)]
        HRESULT get_Red([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(120)]
        HRESULT get_RosyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(121)]
        HRESULT get_RoyalBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(122)]
        HRESULT get_SaddleBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(123)]
        HRESULT get_Salmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(124)]
        HRESULT get_SandyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(125)]
        HRESULT get_SeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(126)]
        HRESULT get_SeaShell([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(127)]
        HRESULT get_Sienna([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(128)]
        HRESULT get_Silver([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(129)]
        HRESULT get_SkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(130)]
        HRESULT get_SlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(131)]
        HRESULT get_SlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(132)]
        HRESULT get_Snow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(133)]
        HRESULT get_SpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(134)]
        HRESULT get_SteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(135)]
        HRESULT get_Tan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(136)]
        HRESULT get_Teal([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(137)]
        HRESULT get_Thistle([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(138)]
        HRESULT get_Tomato([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(139)]
        HRESULT get_Transparent([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(140)]
        HRESULT get_Turquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(141)]
        HRESULT get_Violet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(142)]
        HRESULT get_Wheat([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(143)]
        HRESULT get_White([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(144)]
        HRESULT get_WhiteSmoke([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(145)]
        HRESULT get_Yellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(146)]
        HRESULT get_YellowGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_AliceBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_AntiqueWhite;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Aqua;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Aquamarine;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Azure;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Beige;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Bisque;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Black;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_BlanchedAlmond;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Blue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_BlueViolet;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Brown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_BurlyWood;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_CadetBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Chartreuse;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Chocolate;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Coral;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_CornflowerBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Cornsilk;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Crimson;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Cyan;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkCyan;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkGoldenrod;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkKhaki;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkMagenta;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkOliveGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkOrange;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkOrchid;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkSalmon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkSeaGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkSlateBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkSlateGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkTurquoise;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DarkViolet;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DeepPink;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DeepSkyBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DimGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DodgerBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Firebrick;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_FloralWhite;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_ForestGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Fuchsia;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Gainsboro;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_GhostWhite;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Gold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Goldenrod;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Gray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Green;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_GreenYellow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Honeydew;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_HotPink;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_IndianRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Indigo;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Ivory;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Khaki;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Lavender;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LavenderBlush;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LawnGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LemonChiffon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightCoral;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightCyan;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightGoldenrodYellow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightPink;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSalmon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSeaGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSkyBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSlateGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightSteelBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LightYellow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Lime;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LimeGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Linen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Magenta;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Maroon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumAquamarine;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumOrchid;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumPurple;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumSeaGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumSlateBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumSpringGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumTurquoise;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MediumVioletRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MidnightBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MintCream;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_MistyRose;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Moccasin;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_NavajoWhite;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Navy;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_OldLace;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Olive;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_OliveDrab;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Orange;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_OrangeRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Orchid;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaleGoldenrod;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaleGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaleTurquoise;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PaleVioletRed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PapayaWhip;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PeachPuff;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Peru;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Pink;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Plum;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_PowderBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Purple;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Red;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_RosyBrown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_RoyalBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SaddleBrown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Salmon;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SandyBrown;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SeaGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SeaShell;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Sienna;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Silver;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SkyBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SlateBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SlateGray;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Snow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SpringGreen;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_SteelBlue;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Tan;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Teal;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Thistle;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Tomato;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Transparent;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Turquoise;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Violet;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Wheat;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_White;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_WhiteSmoke;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Yellow;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_YellowGreen;
    }
}
