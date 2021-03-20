// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFF52E04-CCA6-4614-A17E-754910C84A99")]
    [NativeTypeName("struct IColorsStatics : IInspectable")]
    public unsafe partial struct IColorsStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IColorsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IColorsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IColorsStatics*, uint>)(lpVtbl[1]))((IColorsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IColorsStatics*, uint>)(lpVtbl[2]))((IColorsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IColorsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IColorsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IColorsStatics*, IntPtr*, int>)(lpVtbl[4]))((IColorsStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IColorsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IColorsStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AliceBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[6]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AntiqueWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[7]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Aqua([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[8]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Aquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[9]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Azure([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[10]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Beige([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[11]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Bisque([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[12]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Black([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[13]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BlanchedAlmond([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[14]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Blue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[15]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BlueViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[16]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Brown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[17]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BurlyWood([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[18]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CadetBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[19]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Chartreuse([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[20]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Chocolate([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[21]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Coral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[22]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CornflowerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[23]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Cornsilk([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[24]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Crimson([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[25]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Cyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[26]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[27]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[28]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[29]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[30]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[31]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkKhaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[32]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkMagenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[33]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkOliveGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[34]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkOrange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[35]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[36]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[37]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[38]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[39]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[40]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[41]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[42]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DarkViolet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[43]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DeepPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[44]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DeepSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[45]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DimGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[46]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DodgerBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[47]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Firebrick([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[48]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FloralWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[49]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ForestGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[50]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Fuchsia([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[51]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Gainsboro([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[52]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_GhostWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[53]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Gold([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[54]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Goldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[55]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Gray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[56]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Green([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[57]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_GreenYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[58]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Honeydew([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[59]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HotPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[60]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IndianRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[61]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Indigo([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[62]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Ivory([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[63]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Khaki([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[64]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Lavender([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[65]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LavenderBlush([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[66]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LawnGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[67]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LemonChiffon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[68]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[69]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightCoral([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[70]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightCyan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[71]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightGoldenrodYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[72]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[73]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[74]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightPink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[75]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightSalmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[76]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[77]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightSkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[78]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightSlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[79]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightSteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[80]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LightYellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[81]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Lime([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[82]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LimeGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[83]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Linen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[84]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Magenta([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[85]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Maroon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[86]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumAquamarine([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[87]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[88]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumOrchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[89]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumPurple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[90]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumSeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[91]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumSlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[92]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumSpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[93]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[94]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediumVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[95]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MidnightBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[96]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MintCream([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[97]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MistyRose([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[98]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Moccasin([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[99]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NavajoWhite([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[100]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Navy([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[101]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OldLace([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[102]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Olive([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[103]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OliveDrab([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[104]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Orange([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[105]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OrangeRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[106]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Orchid([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[107]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PaleGoldenrod([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[108]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PaleGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[109]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PaleTurquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[110]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PaleVioletRed([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[111]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PapayaWhip([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[112]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PeachPuff([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[113]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Peru([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[114]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pink([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[115]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Plum([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[116]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PowderBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[117]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Purple([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[118]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Red([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[119]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RosyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[120]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RoyalBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[121]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SaddleBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[122]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Salmon([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[123]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SandyBrown([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[124]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SeaGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[125]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SeaShell([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[126]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Sienna([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[127]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Silver([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[128]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SkyBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[129]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SlateBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[130]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SlateGray([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[131]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Snow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[132]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SpringGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[133]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SteelBlue([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[134]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Tan([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[135]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Teal([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[136]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Thistle([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[137]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Tomato([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[138]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Transparent([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[139]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Turquoise([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[140]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Violet([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[141]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Wheat([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[142]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_White([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[143]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WhiteSmoke([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[144]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Yellow([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[145]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_YellowGreen([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
        {
            return ((delegate* unmanaged<IColorsStatics*, Color*, int>)(lpVtbl[146]))((IColorsStatics*)Unsafe.AsPointer(ref this), value);
        }
    }
}
