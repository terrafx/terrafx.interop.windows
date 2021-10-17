// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6C3-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLComputedStyle : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLComputedStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, uint>)(lpVtbl[1]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, uint>)(lpVtbl[2]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_bold([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[3]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_italic([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[4]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_underline([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[5]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_overline([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[6]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_strikeOut([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[7]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_subScript([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[8]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_superScript([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[9]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_explicitFace([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[10]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontWeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, int*, int>)(lpVtbl[11]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontSize([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, int*, int>)(lpVtbl[12]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_fontName([NativeTypeName("TCHAR *")] ushort* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, ushort*, int>)(lpVtbl[13]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasBgColor([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[14]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_textColor([NativeTypeName("DWORD *")] uint* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, uint*, int>)(lpVtbl[15]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_backgroundColor([NativeTypeName("DWORD *")] uint* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, uint*, int>)(lpVtbl[16]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_preFormatted([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[17]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_direction([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[18]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_blockDirection([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[19]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_OL([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int>)(lpVtbl[20]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqual(IHTMLComputedStyle* pComputedStyle, [NativeTypeName("VARIANT_BOOL *")] short* pfEqual)
        {
            return ((delegate* unmanaged<IHTMLComputedStyle*, IHTMLComputedStyle*, short*, int>)(lpVtbl[21]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), pComputedStyle, pfEqual);
        }
    }
}
