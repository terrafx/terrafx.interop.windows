// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("76C6A6F5-4955-4DE5-B27B-14B734CC14B4")]
    [NativeTypeName("struct IMFTimedTextRuby : IUnknown")]
    public unsafe partial struct IMFTimedTextRuby
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedTextRuby*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedTextRuby*, uint>)(lpVtbl[1]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedTextRuby*, uint>)(lpVtbl[2]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRubyText([NativeTypeName("LPWSTR *")] ushort** rubyText)
        {
            return ((delegate* unmanaged<IMFTimedTextRuby*, ushort**, int>)(lpVtbl[3]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), rubyText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRubyPosition(MF_TIMED_TEXT_RUBY_POSITION* value)
        {
            return ((delegate* unmanaged<IMFTimedTextRuby*, MF_TIMED_TEXT_RUBY_POSITION*, int>)(lpVtbl[4]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRubyAlign(MF_TIMED_TEXT_RUBY_ALIGN* value)
        {
            return ((delegate* unmanaged<IMFTimedTextRuby*, MF_TIMED_TEXT_RUBY_ALIGN*, int>)(lpVtbl[5]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRubyReserve(MF_TIMED_TEXT_RUBY_RESERVE* value)
        {
            return ((delegate* unmanaged<IMFTimedTextRuby*, MF_TIMED_TEXT_RUBY_RESERVE*, int>)(lpVtbl[6]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), value);
        }
    }
}
