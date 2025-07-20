namespace Acme.BookStore.Permissions;

public static class BookStorePermissions
{
    public const string GroupName = "BookStore";

    // other permissions...
    // other permissions...

    // Define the Dashboard permissions here
    public static class Dashboard
    {
        public const string Host = GroupName + ".Dashboard.Host";
        public const string Tenant = GroupName + ".Dashboard.Tenant";
    }

    // *** ADDED a NEW NESTED CLASS ***
    public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Authors
    {
        public const string Default = GroupName + ".Authors";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
