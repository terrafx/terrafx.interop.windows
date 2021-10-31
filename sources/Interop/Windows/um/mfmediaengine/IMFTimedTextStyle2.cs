// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB639199-C809-4C89-BFCA-D0BBB9729D6E")]
    [NativeTypeName("struct IMFTimedTextStyle2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedTextStyle2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle2*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedTextStyle2*, uint>)(lpVtbl[1]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedTextStyle2*, uint>)(lpVtbl[2]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuby(IMFTimedTextRuby** ruby)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle2*, IMFTimedTextRuby**, int>)(lpVtbl[3]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), ruby);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetBouten(IMFTimedTextBouten** bouten)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle2*, IMFTimedTextBouten**, int>)(lpVtbl[4]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), bouten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int IsTextCombined(BOOL* value)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle2*, BOOL*, int>)(lpVtbl[5]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAngleInDegrees(double* value)
        {
            return ((delegate* unmanaged<IMFTimedTextStyle2*, double*, int>)(lpVtbl[6]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
