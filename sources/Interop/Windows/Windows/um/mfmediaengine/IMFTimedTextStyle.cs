// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0")]
    [Guid("09B2455D-B834-4F01-A347-9052E21C450E")]
    [NativeTypeName("struct IMFTimedTextStyle : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedTextStyle : IMFTimedTextStyle.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, uint>)(lpVtbl[1]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, uint>)(lpVtbl[2]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, ushort**, int>)(lpVtbl[3]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public BOOL IsExternal()
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, int>)(lpVtbl[4]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetFontFamily([NativeTypeName("LPWSTR *")] ushort** fontFamily)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, ushort**, int>)(lpVtbl[5]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetFontSize(double* fontSize, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[6]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontSize, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetColor(MFARGB* color)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, MFARGB*, int>)(lpVtbl[7]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetBackgroundColor(MFARGB* bgColor)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, MFARGB*, int>)(lpVtbl[8]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), bgColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetShowBackgroundAlways(BOOL* showBackgroundAlways)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, BOOL*, int>)(lpVtbl[9]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), showBackgroundAlways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetFontStyle(MF_TIMED_TEXT_FONT_STYLE* fontStyle)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, MF_TIMED_TEXT_FONT_STYLE*, int>)(lpVtbl[10]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetBold(BOOL* bold)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, BOOL*, int>)(lpVtbl[11]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), bold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetRightToLeft(BOOL* rightToLeft)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, BOOL*, int>)(lpVtbl[12]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), rightToLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetTextAlignment(MF_TIMED_TEXT_ALIGNMENT* textAlign)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, MF_TIMED_TEXT_ALIGNMENT*, int>)(lpVtbl[13]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), textAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetTextDecoration([NativeTypeName("DWORD *")] uint* textDecoration)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, uint*, int>)(lpVtbl[14]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), textDecoration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetTextOutline(MFARGB* color, double* thickness, double* blurRadius, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle*, MFARGB*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[15]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), color, thickness, blurRadius, unitType);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

            [VtblIndex(4)]
            BOOL IsExternal();

            [VtblIndex(5)]
            HRESULT GetFontFamily([NativeTypeName("LPWSTR *")] ushort** fontFamily);

            [VtblIndex(6)]
            HRESULT GetFontSize(double* fontSize, MF_TIMED_TEXT_UNIT_TYPE* unitType);

            [VtblIndex(7)]
            HRESULT GetColor(MFARGB* color);

            [VtblIndex(8)]
            HRESULT GetBackgroundColor(MFARGB* bgColor);

            [VtblIndex(9)]
            HRESULT GetShowBackgroundAlways(BOOL* showBackgroundAlways);

            [VtblIndex(10)]
            HRESULT GetFontStyle(MF_TIMED_TEXT_FONT_STYLE* fontStyle);

            [VtblIndex(11)]
            HRESULT GetBold(BOOL* bold);

            [VtblIndex(12)]
            HRESULT GetRightToLeft(BOOL* rightToLeft);

            [VtblIndex(13)]
            HRESULT GetTextAlignment(MF_TIMED_TEXT_ALIGNMENT* textAlign);

            [VtblIndex(14)]
            HRESULT GetTextDecoration([NativeTypeName("DWORD *")] uint* textDecoration);

            [VtblIndex(15)]
            HRESULT GetTextOutline(MFARGB* color, double* thickness, double* blurRadius, MF_TIMED_TEXT_UNIT_TYPE* unitType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, ushort**, int> GetName;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, int> IsExternal;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, ushort**, int> GetFontFamily;

            [NativeTypeName("HRESULT (double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int> GetFontSize;

            [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, MFARGB*, int> GetColor;

            [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, MFARGB*, int> GetBackgroundColor;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, BOOL*, int> GetShowBackgroundAlways;

            [NativeTypeName("HRESULT (MF_TIMED_TEXT_FONT_STYLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, MF_TIMED_TEXT_FONT_STYLE*, int> GetFontStyle;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, BOOL*, int> GetBold;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, BOOL*, int> GetRightToLeft;

            [NativeTypeName("HRESULT (MF_TIMED_TEXT_ALIGNMENT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, MF_TIMED_TEXT_ALIGNMENT*, int> GetTextAlignment;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, uint*, int> GetTextDecoration;

            [NativeTypeName("HRESULT (MFARGB *, double *, double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextStyle*, MFARGB*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int> GetTextOutline;
        }
    }
}
