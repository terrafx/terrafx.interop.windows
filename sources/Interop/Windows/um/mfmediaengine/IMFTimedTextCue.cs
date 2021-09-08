// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1E560447-9A2B-43E1-A94C-B0AAABFBFBC9")]
    [NativeTypeName("struct IMFTimedTextCue : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedTextCue
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, uint>)(lpVtbl[1]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, uint>)(lpVtbl[2]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint GetId()
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, uint>)(lpVtbl[3]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetOriginalId([NativeTypeName("LPWSTR *")] ushort** originalId)
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, ushort**, int>)(lpVtbl[4]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), originalId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public MF_TIMED_TEXT_TRACK_KIND GetCueKind()
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, MF_TIMED_TEXT_TRACK_KIND>)(lpVtbl[5]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public double GetStartTime()
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, double>)(lpVtbl[6]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public double GetDuration()
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, double>)(lpVtbl[7]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("DWORD")]
        public uint GetTrackId()
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, uint>)(lpVtbl[8]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetData(IMFTimedTextBinary** data)
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, IMFTimedTextBinary**, int>)(lpVtbl[9]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegion(IMFTimedTextRegion** region)
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, IMFTimedTextRegion**, int>)(lpVtbl[10]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), region);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetStyle(IMFTimedTextStyle** style)
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, IMFTimedTextStyle**, int>)(lpVtbl[11]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), style);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("DWORD")]
        public uint GetLineCount()
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, uint>)(lpVtbl[12]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetLine([NativeTypeName("DWORD")] uint index, IMFTimedTextFormattedText** line)
        {
            return ((delegate* unmanaged<IMFTimedTextCue*, uint, IMFTimedTextFormattedText**, int>)(lpVtbl[13]))((IMFTimedTextCue*)Unsafe.AsPointer(ref this), index, line);
        }
    }
}
