// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("55CE16BA-3014-41C1-9CEB-FADE1446AC6C")]
    [NativeTypeName("struct ITfInsertAtSelection : IUnknown")]
    public unsafe partial struct ITfInsertAtSelection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfInsertAtSelection*, Guid*, void**, int>)(lpVtbl[0]))((ITfInsertAtSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfInsertAtSelection*, uint>)(lpVtbl[1]))((ITfInsertAtSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfInsertAtSelection*, uint>)(lpVtbl[2]))((ITfInsertAtSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertTextAtSelection([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch, [NativeTypeName("ITfRange **")] ITfRange** ppRange)
        {
            return ((delegate* unmanaged<ITfInsertAtSelection*, uint, uint, ushort*, int, ITfRange**, int>)(lpVtbl[3]))((ITfInsertAtSelection*)Unsafe.AsPointer(ref this), ec, dwFlags, pchText, cch, ppRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEmbeddedAtSelection([NativeTypeName("TfEditCookie")] uint ec, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("ITfRange **")] ITfRange** ppRange)
        {
            return ((delegate* unmanaged<ITfInsertAtSelection*, uint, uint, IDataObject*, ITfRange**, int>)(lpVtbl[4]))((ITfInsertAtSelection*)Unsafe.AsPointer(ref this), ec, dwFlags, pDataObject, ppRange);
        }
    }
}
