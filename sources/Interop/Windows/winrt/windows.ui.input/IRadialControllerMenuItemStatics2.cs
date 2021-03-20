// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0CBB70BE-7E3E-48BD-BE04-2C7FCAA9C1FF")]
    [NativeTypeName("struct IRadialControllerMenuItemStatics2 : IInspectable")]
    public unsafe partial struct IRadialControllerMenuItemStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics2*, uint>)(lpVtbl[1]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics2*, uint>)(lpVtbl[2]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics2*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromFontGlyph([NativeTypeName("HSTRING")] IntPtr displayText, [NativeTypeName("HSTRING")] IntPtr glyph, [NativeTypeName("HSTRING")] IntPtr fontFamily, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics2*, IntPtr, IntPtr, IntPtr, IRadialControllerMenuItem**, int>)(lpVtbl[6]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), displayText, glyph, fontFamily, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromFontGlyphWithUri([NativeTypeName("HSTRING")] IntPtr displayText, [NativeTypeName("HSTRING")] IntPtr glyph, [NativeTypeName("HSTRING")] IntPtr fontFamily, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* fontUri, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics2*, IntPtr, IntPtr, IntPtr, IUriRuntimeClass*, IRadialControllerMenuItem**, int>)(lpVtbl[7]))((IRadialControllerMenuItemStatics2*)Unsafe.AsPointer(ref this), displayText, glyph, fontFamily, fontUri, result);
        }
    }
}
