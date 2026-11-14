// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propkey.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STORAGE
{
    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARE_STATUS_PRIVATE"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_PRIVATE L\"Private\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_PRIVATE = "Private";

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARE_STATUS_SHARED"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_SHARED L\"Shared\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_SHARED = "Shared";

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARE_STATUS_PUBLIC"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_PUBLIC L\"Public\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_PUBLIC = "Public";

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARE_STATUS_GROUP"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_GROUP L\"Group\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_GROUP = "Group";

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARE_STATUS_OWNER"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARE_STATUS_OWNER L\"Owner\"")]
    public const string STORAGE_PROVIDER_SHARE_STATUS_OWNER = "Owner";

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARINGSTATUS_NOTSHARED"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_NOTSHARED 0ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_NOTSHARED = 0U;

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARINGSTATUS_SHARED"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_SHARED 1ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_SHARED = 1U;

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARINGSTATUS_PRIVATE"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_PRIVATE 2ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_PRIVATE = 2U;

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC 3ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC = 3U;

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARINGSTATUS_SHARED_OWNED"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_SHARED_OWNED 4ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_SHARED_OWNED = 4U;

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARINGSTATUS_SHARED_COOWNED"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_SHARED_COOWNED 5ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_SHARED_COOWNED = 5U;

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_OWNED"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_OWNED 6ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_OWNED = 6U;

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_COOWNED"]/*' />
    [NativeTypeName("#define STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_COOWNED 7ul")]
    public const uint STORAGE_PROVIDER_SHARINGSTATUS_PUBLIC_COOWNED = 7U;
}
