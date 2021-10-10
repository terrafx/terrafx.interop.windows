// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfspui.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90E9A944-9244-489F-A78F-DE67AFC013A7")]
    [NativeTypeName("struct ITfSpeechUIServer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfSpeechUIServer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfSpeechUIServer*, Guid*, void**, int>)(lpVtbl[0]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfSpeechUIServer*, uint>)(lpVtbl[1]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfSpeechUIServer*, uint>)(lpVtbl[2]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize()
        {
            return ((delegate* unmanaged<ITfSpeechUIServer*, int>)(lpVtbl[3]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ShowUI([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<ITfSpeechUIServer*, int, int>)(lpVtbl[4]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateBalloon(TfLBBalloonStyle style, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ITfSpeechUIServer*, TfLBBalloonStyle, ushort*, uint, int>)(lpVtbl[5]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this), style, pch, cch);
        }
    }
}
