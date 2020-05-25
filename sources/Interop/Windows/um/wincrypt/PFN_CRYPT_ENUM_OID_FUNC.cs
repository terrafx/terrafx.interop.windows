// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CRYPT_ENUM_OID_FUNC([NativeTypeName("DWORD")] uint dwEncodingType, [NativeTypeName("LPCSTR")] sbyte* pszFuncName, [NativeTypeName("LPCSTR")] sbyte* pszOID, [NativeTypeName("DWORD")] uint cValue, [NativeTypeName("const DWORD []")] uint rgdwValueType, [NativeTypeName("const LPCWSTR []")] ushort* rgpwszValueName, [NativeTypeName("const BYTE *const []")] byte* rgpbValueData, [NativeTypeName("const DWORD []")] uint rgcbValueData, [NativeTypeName("void *")] void* pvArg);
}
