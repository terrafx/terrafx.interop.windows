// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.15063.0")]
    [Guid("74ABBC19-B1CC-4E41-BB8B-9D9B86A8F6CA")]
    [NativeTypeName("struct IMFMuxStreamSampleManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMuxStreamSampleManager : IMFMuxStreamSampleManager.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint>)(lpVtbl[1]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint>)(lpVtbl[2]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint*, int>)(lpVtbl[3]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), pdwMuxStreamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSample([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFSample** ppSample)
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, uint, IMFSample**, int>)(lpVtbl[4]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this), dwMuxStreamIndex, ppSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("ULONGLONG")]
        public ulong GetStreamConfiguration()
        {
            return ((delegate* unmanaged<IMFMuxStreamSampleManager*, ulong>)(lpVtbl[5]))((IMFMuxStreamSampleManager*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount);

            [VtblIndex(4)]
            HRESULT GetSample([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFSample** ppSample);

            [VtblIndex(5)]
            [return: NativeTypeName("ULONGLONG")]
            ulong GetStreamConfiguration();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMuxStreamSampleManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMuxStreamSampleManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMuxStreamSampleManager*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMuxStreamSampleManager*, uint*, int> GetStreamCount;

            [NativeTypeName("HRESULT (DWORD, IMFSample **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMuxStreamSampleManager*, uint, IMFSample**, int> GetSample;

            [NativeTypeName("ULONGLONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMuxStreamSampleManager*, ulong> GetStreamConfiguration;
        }
    }
}
