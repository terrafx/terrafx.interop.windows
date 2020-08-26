// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3F96EE40-AD81-4096-8470-59A4B770F89A")]
    [NativeTypeName("struct IMFContentDecryptionModuleSessionCallbacks : IUnknown")]
    public unsafe partial struct IMFContentDecryptionModuleSessionCallbacks
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSessionCallbacks*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSessionCallbacks*, uint>)(lpVtbl[1]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSessionCallbacks*, uint>)(lpVtbl[2]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int KeyMessage(MF_MEDIAKEYSESSION_MESSAGETYPE messageType, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint messageSize, [NativeTypeName("LPCWSTR")] ushort* destinationURL)
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSessionCallbacks*, MF_MEDIAKEYSESSION_MESSAGETYPE, byte*, uint, ushort*, int>)(lpVtbl[3]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this), messageType, message, messageSize, destinationURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int KeyStatusChanged()
        {
            return ((delegate* stdcall<IMFContentDecryptionModuleSessionCallbacks*, int>)(lpVtbl[4]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
        }
    }
}
