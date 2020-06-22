// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09B2455D-B834-4F01-A347-9052E21C450E")]
    public unsafe partial struct IMFTimedTextStyle
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, uint>)(lpVtbl[1]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, uint>)(lpVtbl[2]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, ushort**, int>)(lpVtbl[3]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("BOOL")]
        public int IsExternal()
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, int>)(lpVtbl[4]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("LPWSTR *")] ushort** fontFamily)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, ushort**, int>)(lpVtbl[5]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontFamily);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSize([NativeTypeName("double *")] double* fontSize, [NativeTypeName("MF_TIMED_TEXT_UNIT_TYPE *")] MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[6]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontSize, unitType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColor([NativeTypeName("MFARGB *")] MFARGB* color)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, MFARGB*, int>)(lpVtbl[7]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), color);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor([NativeTypeName("MFARGB *")] MFARGB* bgColor)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, MFARGB*, int>)(lpVtbl[8]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), bgColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetShowBackgroundAlways([NativeTypeName("BOOL *")] int* showBackgroundAlways)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, int*, int>)(lpVtbl[9]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), showBackgroundAlways);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle([NativeTypeName("MF_TIMED_TEXT_FONT_STYLE *")] MF_TIMED_TEXT_FONT_STYLE* fontStyle)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, MF_TIMED_TEXT_FONT_STYLE*, int>)(lpVtbl[10]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), fontStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBold([NativeTypeName("BOOL *")] int* bold)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, int*, int>)(lpVtbl[11]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), bold);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRightToLeft([NativeTypeName("BOOL *")] int* rightToLeft)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, int*, int>)(lpVtbl[12]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), rightToLeft);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextAlignment([NativeTypeName("MF_TIMED_TEXT_ALIGNMENT *")] MF_TIMED_TEXT_ALIGNMENT* textAlign)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, MF_TIMED_TEXT_ALIGNMENT*, int>)(lpVtbl[13]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), textAlign);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextDecoration([NativeTypeName("DWORD *")] uint* textDecoration)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, uint*, int>)(lpVtbl[14]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), textDecoration);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextOutline([NativeTypeName("MFARGB *")] MFARGB* color, [NativeTypeName("double *")] double* thickness, [NativeTypeName("double *")] double* blurRadius, [NativeTypeName("MF_TIMED_TEXT_UNIT_TYPE *")] MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* stdcall<IMFTimedTextStyle*, MFARGB*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[15]))((IMFTimedTextStyle*)Unsafe.AsPointer(ref this), color, thickness, blurRadius, unitType);
        }
    }
}
