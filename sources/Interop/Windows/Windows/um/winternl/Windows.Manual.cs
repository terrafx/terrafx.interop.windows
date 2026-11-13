// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static bool NT_SUCCESS([NativeTypeName("NTSTATUS")] int Status)
        => Status >= 0;

    public static bool NT_INFORMATION([NativeTypeName("NTSTATUS")] int Status)
        => (unchecked((uint)Status) >> 30) == 1;

    public static bool NT_WARNING([NativeTypeName("NTSTATUS")] int Status)
        => (unchecked((uint)Status) >> 30) == 2;

    public static bool NT_ERROR([NativeTypeName("NTSTATUS")] int Status)
        => (unchecked((uint)Status) >> 30) == 3;

    public static void InitializeObjectAttributes(OBJECT_ATTRIBUTES* p, UNICODE_STRING* n, uint a, HANDLE r, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* s)
    {
        p->Length = (uint)sizeof(OBJECT_ATTRIBUTES);
        p->RootDirectory = r;
        p->Attributes = a;
        p->ObjectName = n;
        p->SecurityDescriptor = s;
        p->SecurityQualityOfService = null;
    }
}
