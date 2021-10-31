// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5F309A41-590A-4ACC-A97F-D8EFFF13FDFC")]
    [NativeTypeName("struct ITfFnGetPreferredTouchKeyboardLayout : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnGetPreferredTouchKeyboardLayout
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, uint>)(lpVtbl[1]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, uint>)(lpVtbl[2]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, ushort**, int>)(lpVtbl[3]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetLayout(TKBLayoutType* pTKBLayoutType, [NativeTypeName("WORD *")] ushort* pwPreferredLayoutId)
        {
            return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, TKBLayoutType*, ushort*, int>)(lpVtbl[4]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this), pTKBLayoutType, pwPreferredLayoutId);
        }
    }
}
