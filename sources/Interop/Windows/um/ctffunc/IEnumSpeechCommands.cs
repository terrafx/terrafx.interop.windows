// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8C5DAC4F-083C-4B85-A4C9-71746048ADCA")]
    [NativeTypeName("struct IEnumSpeechCommands : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumSpeechCommands
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSpeechCommands*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSpeechCommands*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSpeechCommands*, uint>)(lpVtbl[1]))((IEnumSpeechCommands*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSpeechCommands*, uint>)(lpVtbl[2]))((IEnumSpeechCommands*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumSpeechCommands** ppEnum)
        {
            return ((delegate* unmanaged<IEnumSpeechCommands*, IEnumSpeechCommands**, int>)(lpVtbl[3]))((IEnumSpeechCommands*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("WCHAR **")] ushort** pSpCmds, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumSpeechCommands*, uint, ushort**, uint*, int>)(lpVtbl[4]))((IEnumSpeechCommands*)Unsafe.AsPointer(ref this), ulCount, pSpCmds, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumSpeechCommands*, int>)(lpVtbl[5]))((IEnumSpeechCommands*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumSpeechCommands*, uint, int>)(lpVtbl[6]))((IEnumSpeechCommands*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
